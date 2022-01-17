using IT___Telefaune.Models;
using IT___Telefaune.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Controllers
{
    public class SiteController : Controller
    {

        private readonly ApplicationDbContext _db;

        public SiteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<SiteModel> objList = _db.Site;

            return View(objList);
        }

        [HttpPost]
        public IActionResult Create(SiteModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Site.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IEnumerable<ServiceModel> displaydata { get; set; }

        public async Task OnGet()
        {
            displaydata = await _db.Service.ToListAsync();
        }

        public IActionResult Create()
        {
            IEnumerable<ServiceModel> serviceList = _db.Service;

            return View();
        }

        public IActionResult DeleteGet(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Site.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? SiteId)
        {
            var obj = _db.Site.Find(SiteId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Site.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Site.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(SiteModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Site.Update(obj);
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
