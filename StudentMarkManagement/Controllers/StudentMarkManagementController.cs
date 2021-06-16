using Microsoft.AspNetCore.Mvc;
using StudentMarkManagement.Core;
using StudentMarkManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarkManagement.Controllers
{
    public class StudentMarkManagementController : Controller
    {
        readonly IStudentMarkServices _studentMarkServices;
        public StudentMarkManagementController(IStudentMarkServices studentMarkServices)
        {
            _studentMarkServices = studentMarkServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DashBoard()
        {
            StudentDetails stdDetails = new StudentDetails();
            stdDetails.Department = _studentMarkServices.GetAllDepartment();
            return View(stdDetails);
        }

        public IActionResult MarkDashBoard()
        {
            StudentDetails stdDetails = new StudentDetails();
            stdDetails.Department = _studentMarkServices.GetAllDepartment();
            return View(stdDetails);
        }


        public IActionResult ViewStudentDetails(StudentDetails stdDetails)
        {

            var list = _studentMarkServices.ViewStudentDetails(stdDetails);
            return View(list);
        }
        [HttpPost]
        public IActionResult SaveStudentDetails(StudentDetails stdDetails)
        {

            _studentMarkServices.SaveStudentDetails(stdDetails);
            return RedirectToAction("ViewStudentDetails");
        }
        public IActionResult DeleteStudentDetails(int id)
        {
            _studentMarkServices.DeleteStudentDetails(id);
            return RedirectToAction("ViewStudentDetails");
        }
    }
}
