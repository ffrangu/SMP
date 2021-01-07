using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SMP.Controllers
{
    public class BonusetController : Controller
    {
        // GET: BonusetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BonusetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonusetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonusetController/Create
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

        // GET: BonusetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonusetController/Edit/5
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

        // GET: BonusetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonusetController/Delete/5
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
