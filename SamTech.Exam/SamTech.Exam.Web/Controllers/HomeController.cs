using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SamTech.Exam.Web.Models;

namespace SamTech.Exam.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(AddStudentModel model)
        {
            model.AddStudent();
            return RedirectToAction("AddStudent");
        }

        public IActionResult AddSubject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSubject(AddSubjectModel model)
        {
            model.AddSubject();
            return RedirectToAction("AddSubject");
        }

        public IActionResult GetSubject()
        {
            return View();
        }

        public IActionResult ShowSubjects()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<GetSubjectModel>();
            var data = model.GetSubjects(tableModel);
            return Json(data);
        }

        public IActionResult AddGrade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGrade(AddGradeModel model)
        {
            model.AddGrade();
            return RedirectToAction("AddGrade");
        }

        public IActionResult GetStudents()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<GetStudentModel>();
            var data = model.GetStudents(tableModel);
            return Json(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
