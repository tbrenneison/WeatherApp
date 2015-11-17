using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

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

        // GET: WeatherorNot
        public ActionResult WeatherorNot()
        {
            return View();
        }
     
        public JsonResult GetWeather(string City)
        {
            Weather weather = new Weather();
            return Json(weather.getWeatherForecast(City), JsonRequestBehavior.AllowGet);
        }
    }
}