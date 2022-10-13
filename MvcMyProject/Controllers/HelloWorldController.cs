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
       /* public IActionResult Index()
        {
            return View();
        }*/

        public string Index()
        {
            return "This is my default action...";
        }


        // Get: HelloWorld/Welcome/

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

    }
}
