using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAppFinal.BusinessLayer.DTOs.Reponse;
using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;
using WebAppFinal.Helpers;

namespace WebAppFinal.Controllers
{
    public class StudentController : Controller
    {
        public readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("/Student/Index")]
        public async Task<IActionResult> Index(SortFilterPageOptions options)
        {
            var res = await _studentService.GetListSortAsync(options);
            return View(res);
        }

        // GET: UserManagerController/Details/5
        /*public async Task<ActionResult> Details(int id)
        {
            var UserProfile = await _studentService.GetByIdAsync(id);
            return View(UserProfile);
        }*/

        // GET: UserManagerController/Create

        public ActionResult Create()
        {
            return View(new Student());
        }

        // POST: UserManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Student entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _studentService.AddAsync(entity))
                    {
                        ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Success, "Create Ok!");
                    }
                    else ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Danger, "Unknown error");
                    //return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }

            return View(entity);
        }

        // GET: UserManagerController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var res = await _studentService.GetByIdAsync(id);
            return View(res);
        }

        // POST: UserManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Student entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _studentService.UpdateAsync(entity))
                    {
                        ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Success, "Update Ok!");
                    }
                    else ViewBag.Alert = AlertsHelper.ShowAlert(Alerts.Danger, "Unknown error");
                    //return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(entity);
        }

        // GET: UserManagerController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _studentService.GetByIdAsync(id);
            return View(res);
        }

        // POST: UserManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            try
            {
                var res = await _studentService.GetByIdAsync(id);
                //await _studentService.DeleteAsync(res);

                return RedirectToAction(nameof(Index));
            }
            catch (InvalidDataException)
            {
                return View();
            }
        }

        public IActionResult Details()
        {
            throw new NotImplementedException();
        }
    }
}