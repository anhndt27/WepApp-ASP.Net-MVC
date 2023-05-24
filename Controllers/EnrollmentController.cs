using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;
using WebAppFinal.Helpers;
using WebAppFinal.Models;

namespace WebAppFinal.Controllers
{
    public class EnrollmentController : Controller
    {
        public readonly IStudentService _studentService;
        public readonly IMapper _mapper;
        public readonly IEnrollmentService _enrollmentService;
        public readonly ICourseServices _courseServices;


        public EnrollmentController(IStudentService studentService, IMapper mapper,
            IEnrollmentService enrollmentService, ICourseServices courseServices)
        {
            _studentService = studentService;
            _enrollmentService = enrollmentService;
            _mapper = mapper;
            _courseServices = courseServices;
        }
        /*public IActionResult Index()
        {
            return View();
        }*/

        public async Task<IActionResult> AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewStudent([FromRoute] int id, int studentID)
        {
            try
            {
                if (await _enrollmentService.AddStudentToCourse(id, studentID))
                {
                    ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Success, "Add new student to course!");
                }
                else ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Danger, "Unknown error");
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again.");
                //ViewBag.Alerts = AlertsHelper.ShowAlert(Alerts.Danger, message: "lane Catch fix bug now");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUseModal(ViewModel model)
        {
            try
            {
                if (await _enrollmentService.AddStudentToCourse(model.model2.CourseId, model.model2.StudentId))
                {
                    //ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Success, "Add new student to course!");
                }
                //else ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Danger, "Unknown error");
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again.");
                //ViewBag.Alerts = AlertsHelper.ShowAlert(Alerts.Danger, message: "lane Catch fix bug now");
            }

            return RedirectToAction("Index", "Course");
        }
    }
}