using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMyProject.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       /* public string Index()
        {
            return "This is my default action...";
        }*/


        // Get: HelloWorld/Welcome/

       /* public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/


        // New code:/ HelloWorldController/Welcome
        // This file required using System.Text.Encodings.WEb;

       /* public string Welcome(string name, int ID = 1)
        {
            //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        }*/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }


    }
}
