using IT___Telefaune.Models;
using IT___Telefaune.Models.Data;
using Microsoft.AspNetCore.Http;
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
            ViewBag.sessionv = HttpContext.Session.GetString("Test");

            return View (objList);
        }

        [HttpPost]
        public IActionResult Create(SiteModel obj)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
            if (ModelState.IsValid)
            {
                var findService = _db.Service.Include(obj.TypeServiceWrong);

                _db.Site.Add(obj);
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
            ViewBag.sessionv = HttpContext.Session.GetString("Test");

            return View();
        }

        public IActionResult DeleteGet(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
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
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
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
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
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
        public IActionResult ConsultUsers(int? id)
        {
            if(id == null || id==0)
            {
                return NotFound();
            }
            var users = _db.Salarie.Where(u => u.SiteId == id);
            var idSite = _db.Site.Find(id);
            string FindNomSite = idSite.NomSite;
            ViewBag.sitename = FindNomSite;

            return View(users.ToList());

        }

    }
}
