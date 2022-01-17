﻿using IT___Telefaune.Models;
using IT___Telefaune.Models.Data;
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

            return View(objList);
        }

        [HttpPost]
        public IActionResult Create(ServiceModel obj)
        {
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
            return View();
        }

        public IActionResult DeleteGet(int? id)
        {
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
    }

}

