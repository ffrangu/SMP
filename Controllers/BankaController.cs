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
using SMP.Models.Bank;

namespace SMP.Controllers
{
    public class BankaController : BaseController
    {

        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }

        private IBankRepository bankRepository;
        

        public BankaController(IBankRepository _bankRepository,RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager,
            AlertService _alertService)
            : base(_roleManager, _userManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            alertService = _alertService;
            bankRepository = _bankRepository;
        }
        // GET: BankaController
        public async Task<ActionResult> IndexAsync()
        {
            var banks = await bankRepository.GetAll();
            return View(banks);
        }

        // GET: BankaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankaController/Create
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

        // GET: BankaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankaController/Edit/5
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

        // GET: BankaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankaController/Delete/5
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
