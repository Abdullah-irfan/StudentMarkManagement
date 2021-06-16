using StudentMarkManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkManagement.Core
{
   public interface IStudentMarkServices
    {
        void SaveStudentDetails(StudentDetails stdDetails);

        void SaveStudentMarkDetails(StudentMarkDetails stdMarkDetails);




        public List<StudentDetails> ViewStudentDetails(StudentDetails stdDetails);

        public List<StudentMarkDetails> ViewStudentMarkDetails(StudentMarkDetails stdMarkDetails);



        public StudentDetails EditStudentDetails(int id);

        public StudentMarkDetails EditStudentMarkDetails(int id);



        void DeleteStudentDetails(int id);

        void DeleteStudentMarkDetails(int id);

        public DepartmentDetails GetDepartmentName(int id);
        List<DepartmentDetails> GetAllDepartment();
    }
}
