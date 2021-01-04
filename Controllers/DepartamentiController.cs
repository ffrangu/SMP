using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMP.Data;
using SMP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Controllers
{
    public class DepartamentiController : BaseController
    {
        public AlertService alertService { get; }

        public DepartamentiController(RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager, AlertService _alertService)
        : base(_roleManager, _userManager)
        {
            alertService = _alertService;
        }


        // GET: DepartamentiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DepartamentiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartamentiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartamentiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartamentiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartamentiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartamentiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
