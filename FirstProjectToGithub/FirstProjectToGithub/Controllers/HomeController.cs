﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectToGithub.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyNewPage()
        {
          return View();
        }
        

        public ActionResult CheckingPage()
        {
            return View();
        }
	}
}
