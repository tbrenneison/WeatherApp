using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        public Object getWeatherForecast(string City)
        {
            string appid = "d98070087a259a39fd584ca1bca32814";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + City + "&APPID=" + appid + "&units=imperial";
            //synchronous client.
            var client = new WebClient();
            //getting the JSON from the API as a string
            var content = client.DownloadString(url);
            //because the JSON is thought to be a stiring, we need to convert to JSON object
            var serializer = new JavaScriptSerializer();
            //changing from a string to a JSON object 
            var jsonContent = serializer.Deserialize<Object>(content);
            //return JSON object
            return jsonContent;
        }

    }
}