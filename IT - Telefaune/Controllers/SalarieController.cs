using IT___Telefaune.Models;
using IT___Telefaune.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Controllers
{
    public class SalarieController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SalarieController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<SalarieModel> objList = _db.Salarie;

            return View(objList);
        }

        [HttpPost]
        public IActionResult Create(SalarieModel obj)
        {
            ModelState.Remove("TelephoneFixe");
            if (ModelState.IsValid)
            {
                _db.Salarie.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Create()
        {
            IEnumerable<SalarieModel> serviceList = _db.Salarie;

            return View();
        }

        public IActionResult DeleteGet(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Salarie.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? SalarieId)
        {
            var obj = _db.Salarie.Find(SalarieId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Salarie.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Salarie.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(SalarieModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Salarie.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
