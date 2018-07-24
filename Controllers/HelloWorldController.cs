using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp.Models;
using System.Text.Encodings.Web;

namespace asp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default view";
        }

        public string Welcome(string name, int numTimes=1)
        {
           return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
