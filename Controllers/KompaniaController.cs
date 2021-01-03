using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Kompania;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Controllers
{
    public class KompaniaController : BaseController
    {
        public AlertService alertService { get; }

        private IKompaniaRepository kompaniaRepository;

        public KompaniaController(IKompaniaRepository _kompaniaRepository, RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager,
            AlertService _alertService)
            : base(_roleManager, _userManager)
        {
            alertService = _alertService;
            kompaniaRepository = _kompaniaRepository;
        }

        // GET: KompaniaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KompaniaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KompaniaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KompaniaController/Create
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

        // GET: KompaniaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KompaniaController/Edit/5
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

        // GET: KompaniaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KompaniaController/Delete/5
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
