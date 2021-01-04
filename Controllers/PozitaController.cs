using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Pozita;
using SMP.ViewModels.Pozita;

namespace SMP.Controllers
{
    public class PozitaController : BaseController
    {

        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }

        private IPozitaRepository pozitaRepository;


        public PozitaController(IPozitaRepository _pozitaRepository, RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager,
            AlertService _alertService)
            : base(_roleManager, _userManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            alertService = _alertService;
            pozitaRepository = _pozitaRepository;
        }


        // GET: PozitaController
        public async Task<ActionResult> IndexAsync()
        {
            var pozitat = await pozitaRepository.GetPozitat();
            var listItems = new List<PozitaListViewModel>();

            foreach (var item in pozitat)
            {
                listItems.Add(new PozitaListViewModel
                {
                    Id = item.Id,
                    DepartmentiId = item.DepartamentiId,
                    Departamenti = item.Departamenti.Emri,
                    KompaniaId = item.KompaniaId,
                    Kompania = item.Kompania.Emri,
                    Emri = item.Emri,
                    Status = item.Status,
                    Created = item.Created,
                    CreatedBy = item.CreatedBy
                    

                });
            }

            return View(listItems);
        }

        // GET: PozitaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PozitaController/Create
        public async Task<ActionResult> CreateAsync()
        {
            return View();
        }

        // POST: PozitaController/Create
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

        // GET: PozitaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PozitaController/Edit/5
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

        // GET: PozitaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PozitaController/Delete/5
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
