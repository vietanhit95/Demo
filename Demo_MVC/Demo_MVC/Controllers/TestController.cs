﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_MVC.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Home()
        {
            return View();
        }
	}
}