using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMarkManagement.Core;
using StudentMarkManagement.Core.Model;
using StudentMarkManagement.Entity;

namespace StudentMarkManagement.Resources
{
  public  class StudentMarkRepositories : IStudentMarkRepositories
    {
        public void DeleteStudentDetails(int id)
        {
            StudentDetails studentDeails = new StudentDetails();
            using (var entites = new StudentmarkmanagementEntity())
            {
                var studentData = entites.StudentPersonalDetail.Where(x => x.Student_Id == id).SingleOrDefault();
                if (studentData != null)
                {
                    studentData.Is_Deleted = true;
                    studentData.Updated_Time_Stamp = DateTime.Now;
                    entites.SaveChanges();
                }
            }
        }

        public void DeleteStudentMarkDetails(int id)
        {
            throw new NotImplementedException();
        }

        public StudentDetails EditStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public StudentMarkDetails EditStudentMarkDetails(int id)
        {
            throw new NotImplementedException();
        }

        public DepartmentDetails GetDepartmentName(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveStudentDetails(StudentDetails stdDetails)
        {
            StudentPersonalDetail student = new StudentPersonalDetail();
           
               using (var entity= new StudentmarkmanagementEntity())
                {
                    student.Student_Id = stdDetails.StudentId;
                    student.Student_Name = stdDetails.StudentName;
                    student.Student_Email = stdDetails.StudentEmail;
                if (stdDetails.StudentDepartment=="1")
                {
                    stdDetails.StudentDepartment = "CSE";
                }
                else if (stdDetails.StudentDepartment=="2")
                {
                    stdDetails.StudentDepartment = "MSC";
                }
                else if (stdDetails.StudentDepartment == "3")
                {
                    stdDetails.StudentDepartment = "MBA";
                }
                else if (stdDetails.StudentDepartment =="4")
                {
                    stdDetails.StudentDepartment = "B.TECH";
                }
                student.Student_Department = stdDetails.StudentDepartment;
                    student.Gender = stdDetails.Gender;
                    entity.StudentPersonalDetail.Add(student);
                    entity.SaveChanges();
                }

            
        }

        public void SaveStudentMarkDetails(StudentMarkDetails stdMarkDetails)
        {
            StudentMarkDetail student = new StudentMarkDetail();

            using (var entity = new StudentmarkmanagementEntity())
            {
                student.Student_Id = stdMarkDetails.StuduentId;
                student.Student_Name = stdMarkDetails.StuduentName;
                student.Mark_1 = stdMarkDetails.Mark1;
                student.Mark_2 = stdMarkDetails.Mark2;
                student.Total = (student.Mark_1 + student.Mark_2);
                entity.StudentMarkDetail.Add(student);
                entity.SaveChanges();
            }

        }

        public List<StudentDetails> ViewStudentDetails(StudentDetails stdDetails)
        {
            List<StudentDetails> studentList = new List<StudentDetails>();
            using (var entites = new StudentmarkmanagementEntity())
            {
                var studentDb = entites.StudentPersonalDetail.Where(x => x.Is_Deleted == false).ToList();
                if (studentDb != null)
                {
                    foreach (var studentTable in studentDb)
                    {
                        StudentDetails studentDetails = new StudentDetails();
                        studentDetails.StudentId = studentTable.Student_Id;
                        studentDetails.StudentName = studentTable.Student_Name;
                        studentDetails.StudentEmail = studentTable.Student_Email;
                        studentDetails.StudentDepartment = studentTable.Student_Department;
                        studentDetails.Gender = studentTable.Gender;

                        studentList.Add(studentDetails);
                    }
                }
            }
            return studentList;
        }

        #region GetAllDepartment
        public List<DepartmentDetails> GetAllDepartment()
        {
            List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
            using (var entites = new StudentmarkmanagementEntity())
            {
                var dbDepartment = entites.DepartmentDetail.Where(x => x.Is_Deleted == false).ToList();
                if (dbDepartment != null)
                {
                    foreach (var departmntData in dbDepartment)
                    {
                        DepartmentDetails departmentDetails = new DepartmentDetails();
                        departmentDetails.DepartmentId = departmntData.Department_Id;
                        departmentDetails.DepartmentName = departmntData.Department_Name;
                        departmentList.Add(departmentDetails);
                    }
                }
            }
            return departmentList;
        }
        #endregion

        public List<StudentMarkDetails> ViewStudentMarkDetails(StudentMarkDetails stdMarkDetails)
        {
            List<StudentMarkDetails> studentList = new List<StudentMarkDetails>();
            using (var entites = new StudentmarkmanagementEntity())
            {
                var studentDb = entites.StudentMarkDetail.Where(x => x.Is_Deleted == false).ToList();
                if (studentDb != null)
                {
                    foreach (var studentTable in studentDb)
                    {
                        StudentMarkDetails studentDetails = new StudentMarkDetails();
                        studentDetails.StuduentId = studentTable.Student_Id;
                        studentDetails.StuduentName = studentTable.Student_Name;
                        studentDetails.Mark1 = studentTable.Mark_1;
                        studentDetails.Mark2 = studentTable.Mark_2;
                        studentDetails.Total= studentTable.Total;

                        studentList.Add(studentDetails);
                    }
                }
            }
            return studentList;
        }
    }
}
