using StudentMarkManagement.Core;
using StudentMarkManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkManagement.Services
{
    public class StudentMarkServices : IStudentMarkServices
    {

        #region MyRegion
        readonly IStudentMarkRepositories _studentMarkRepositories;
        public StudentMarkServices(IStudentMarkRepositories studentMarkRepositories)
        {
            _studentMarkRepositories = studentMarkRepositories;
        }
        #endregion

        public void DeleteStudentDetails(int id)
        {
            _studentMarkRepositories.DeleteStudentDetails(id);
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
            _studentMarkRepositories.SaveStudentDetails(stdDetails);
        }

        public void SaveStudentMarkDetails(StudentMarkDetails stdMarkDetails)
        {
            throw new NotImplementedException();
        }

        public List<StudentDetails> ViewStudentDetails(StudentDetails stdDetails)
        {
            return _studentMarkRepositories.ViewStudentDetails(stdDetails);
        }

        public List<StudentMarkDetails> ViewStudentMarkDetails(StudentMarkDetails stdMarkDetails)
        {
            throw new NotImplementedException();
        }

        #region GetAllDepartment
        public List<DepartmentDetails> GetAllDepartment()
        {
            return _studentMarkRepositories.GetAllDepartment();
        }
        #endregion
    }
}
