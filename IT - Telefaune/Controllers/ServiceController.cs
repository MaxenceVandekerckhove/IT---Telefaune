using IT___Telefaune.Models;
using IT___Telefaune.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Controllers
{
    public class ServiceController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ServiceController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ServiceModel> objList = _db.Service;
            ViewBag.sessionv = HttpContext.Session.GetString("Test");

            return View(objList);
        }

        [HttpPost]
        public IActionResult Create(ServiceModel obj)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
            if (ModelState.IsValid)
            {
                _db.Service.Add(obj);
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
            var obj = _db.Service.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? ServiceId)
        {
            var obj = _db.Service.Find(ServiceId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Service.Remove(obj);
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
            var obj = _db.Service.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(ServiceModel obj)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
            if (ModelState.IsValid)
            {
                _db.Service.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ConsultSites(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var sites = _db.Site.Where(s => s.ServiceId == id);
            var typeService = _db.Service.Find(id);
            string FindService = typeService.TypeService;
            ViewBag.typeservice = FindService;

            return View(sites.ToList());

        }

        public IActionResult ConsultUsers(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var users = _db.Salarie.Where(u => u.ServiceId == id);
            var idService = _db.Service.Find(id);
            string FindTypeService = idService.TypeService;
            ViewBag.typeservice = FindTypeService;

            return View(users.ToList());

        }

    }

}

