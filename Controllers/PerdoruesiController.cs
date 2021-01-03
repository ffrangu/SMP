using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMP.Data;
using SMP.Helpers;

namespace SMP.Controllers
{
    public class PerdoruesiController : BaseController
    {
        // GET: PerdoruesiController

        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }
        private readonly IEmailSender emailSender;

        public PerdoruesiController(RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager,
            AlertService _alertService, IEmailSender _emailSender) 
            : base(_roleManager, _userManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            emailSender = _emailSender;
            alertService = _alertService;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var users = await userManager.Users.ToListAsync();
            var roles = await roleManager.Roles.ToListAsync();

            ViewBag.Roles = roles;

            return View(users);
        }

        // GET: PerdoruesiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PerdoruesiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerdoruesiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: PerdoruesiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PerdoruesiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: PerdoruesiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PerdoruesiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
