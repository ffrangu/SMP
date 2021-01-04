using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Departamenti;
using SMP.ViewModels.Departamenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Controllers
{
    public class DepartamentiController : BaseController
    {

        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }

        private IDepartamentiRepository departamentiRepository;

        public DepartamentiController(IDepartamentiRepository _departamentiRepository,RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager, AlertService _alertService)
        : base(_roleManager, _userManager)
        {
            alertService = _alertService;
            userManager = _userManager;
            roleManager = _roleManager;
            departamentiRepository = _departamentiRepository;

        }


        // GET: DepartamentiController
        public async Task<ActionResult> IndexAsync()
        {
            var departments = await departamentiRepository.GetDepartments();

            var listItems = new List<DepartamentiListViewModel>();

            foreach (var item in departments)
            {
                listItems.Add(new DepartamentiListViewModel
                {
                    Id = item.Id,
                    KompaniaId = item.KompaniaId,
                    Kompania = item.Kompania.Emri,
                    Emri= item.Emri,
                    Shkurtesa = item.Shkurtesa,
                    Status = item.Status,
                    Created = item.Created,
                    CreatedBy = item.CreatedBy
                    

                });

            }

            return View(listItems);
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
