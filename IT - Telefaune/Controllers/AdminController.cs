using IT___Telefaune.Models;
using IT___Telefaune.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Web;
using Microsoft.AspNetCore.Session;



namespace IT___Telefaune.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AdminModel> objList = _db.Admin;
            ViewBag.sessionv = HttpContext.Session.GetString("Test");

            return View(objList);
        }

        [HttpPost]
        public IActionResult Create(AdminModel obj)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
            var check = _db.Admin.FirstOrDefault(s => s.Email == obj.Email);
            if (ModelState.IsValid && check == null)
            {
                _db.Admin.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.error = "Email déjà utilisé";
                return View();
            }
        }

        public IActionResult Create()
        {
            IEnumerable<AdminModel> serviceList = _db.Admin;
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
            var obj = _db.Admin.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? AdminId)
        {
            var obj = _db.Admin.Find(AdminId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Admin.Remove(obj);
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
            var obj = _db.Admin.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(AdminModel obj)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
            if (ModelState.IsValid)
            {
                _db.Admin.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Login()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("Test");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginPost(string email, string password)
        {
            if(ModelState.IsValid)
            {
                var f_password = password;
                var data = _db.Admin.Where(s => s.Email.Equals(email) && s.Password.Equals(password));
                if (data.Count() > 0)
                {

                    //Session["Email"] = data.FirstOrDefault().Email;
                    //data.FirstOrDefault().Email = Session["Email"];
                    //HttpContext.Session.SetString(SessionKeyEmail, data.FirstOrDefault().Email);
                    HttpContext.Session.SetString("Test", data.FirstOrDefault().Email);
                    return Redirect("/Home/Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            ViewBag.error = "Login failed : ModelState Invalid";
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("Test");
            return Redirect("/Home/Index");
        }
    }
}
