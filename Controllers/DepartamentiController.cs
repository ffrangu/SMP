using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Departamenti;
using SMP.Models.Kompania;
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

        private IKompaniaRepository kompaniaRepository;

        public DepartamentiController(IDepartamentiRepository _departamentiRepository, IKompaniaRepository _kompaniaRepository, RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager, AlertService _alertService)
        : base(_roleManager, _userManager)
        {
            alertService = _alertService;
            userManager = _userManager;
            roleManager = _roleManager;
            departamentiRepository = _departamentiRepository;
            kompaniaRepository = _kompaniaRepository;

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
        public async Task<ActionResult> CreateAsync()
        {
            
            ViewBag.Kompania = await kompaniaRepository.KompaniaSelectList(null, false, false);
            return View();
        }

        // POST: DepartamentiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(DepartamentiCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var addDepartament = new Departamenti
                    {
                        KompaniaId = model.KompaniaId,
                        Emri = model.Emri,
                        Shkurtesa = model.Shkurtesa,
                        Status = model.Status,
                        Created = DateTime.Now,
                        CreatedBy = user.UserName
                    };

                    var result = await departamentiRepository.AddAsync(addDepartament);
                    alertService.Success("Departamenti u shtua me sukses!");
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    alertService.Danger("Diqka shkoi gabim, provoni perseri!");
                    return View(model);
                }
            }
            alertService.Information("Plotesoni te gjitha fushat!");
            return View(model);
        }

        // GET: DepartamentiController/Edit/5
        public async Task<ActionResult> EditAsync(int? id)
        {

            ViewBag.AddError = false;

            if (id == null)
            {
                ViewBag.ErrorTitle = $"Id cannot be null";
                return View("_NotFound");
            }
            var grada = await departamentiRepository.Get(id);

            if (grada == null)
            {
                ViewBag.ErrorTitle = $"Pozita me këtë { id } nuk është gjetur!";
                return View("_NotFound");
            }

            DepartamentiEditViewModel model = new DepartamentiEditViewModel
            {
                Id = grada.Id,
                Emri = grada.Emri,
                KompaniaId = grada.KompaniaId,
                Created = grada.Created,
                CreatedBy = grada.CreatedBy,
                Status = grada.Status,
                Shkurtesa = grada.Shkurtesa
            };

            
            ViewBag.Kompania = await kompaniaRepository.KompaniaSelectList(grada.KompaniaId, false, false);

            return View(model);

        }

        // POST: DepartamentiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(DepartamentiEditViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var editDepartament = await departamentiRepository.Get(model.Id);
                    editDepartament.KompaniaId = model.KompaniaId;
                    editDepartament.Emri = model.Emri;
                    editDepartament.Shkurtesa = model.Shkurtesa;
                    editDepartament.Status = model.Status;
                    editDepartament.Created = DateTime.Now;
                    editDepartament.CreatedBy = user.UserName;

                    var editedDepartment = await departamentiRepository.Update(editDepartament);

                    alertService.Success("Departamenti u editua me sukses!");

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {

                    alertService.Danger("Diqka shkoi keq!");
                    return View(model);
                }
            }

            alertService.Information("Mbushi te gjitha fushat!");

            return View(model);
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
