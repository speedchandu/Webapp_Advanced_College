﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TeachersController : Controller
    {
        private WebApp.Models.WebAppModel db = new Models.WebAppModel();
        // GET: Teachers
        public ActionResult Index()
        {
            var res = db.Teacchers.ToList();
            return View(res);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teachers model)
        {
            if (ModelState.IsValid)
            {
                db.Teacchers.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}