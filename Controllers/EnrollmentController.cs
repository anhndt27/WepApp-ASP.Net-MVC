using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DTOs.Reponse;
using WebAppFinal.Helpers;

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
            //var res = _studentService.Findddd(code).Id;
            try
            {
                var res = await _enrollmentService.AddStudentToCourse(id, studentID);
                if (res)
                {
                    ViewBag.Alerts = AlertsHelper.ShowAlert(Alerts.Success, message: "Ok bro");
                }
                else ViewBag.Alerts = AlertsHelper.ShowAlert(Alerts.Danger, message: "miss add student to course");
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again.");
            }

            return View();
        }
    }
}