﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeatherJS
        public ActionResult WeatherJS()
        {
            return View();
        }

        // GET: SearchforCityJS
        public ActionResult SearchforCityJS()
        {
            return View();
        }
    }
}