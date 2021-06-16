using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkManagement.Core.Model
{
    public class StudentDetails
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string StudentEmail { get; set; }

        public string StudentDepartment { get; set; }
        public List<DepartmentDetails> Department { get; set; }

        public string Gender { get; set; }


    }
}
