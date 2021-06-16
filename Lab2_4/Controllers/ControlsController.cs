using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Lab2_4.Models;

namespace Lab2_4.Controllers
{
    public class ControlsController : Controller
    {
        private readonly ILogger<ControlsController> _logger;

        public ControlsController(ILogger<ControlsController> logger)
        {
            _logger = logger;
        }


        public IActionResult Menu()
        {
            return View();
        }


        public IActionResult TextBox(string State)
        {
            if (Request.Method == "POST")
            {
                ViewBag.Type = "Text Box";
                ViewBag.Name = "Text";
                ViewBag.Value = State;
                return View("Result");
            }
            else return View();
        }


        public IActionResult TextArea(string State)
        {
            if (Request.Method == "POST")
            {
                ViewBag.Type = "Text Area";
                ViewBag.Name = "Text";
                ViewBag.Value = State;
                return View("Result");
            }
            else return View();
        }


        public IActionResult CheckBox(string State)
        {
            if (Request.Method == "POST")
            {
                ViewBag.Type = "Check Box";
                ViewBag.Name = "IsSelected";
                ViewBag.Value = State;
                return View("Result");
            }
            else return View();
        }


        public IActionResult Radio(string State)
        {
            if (Request.Method == "POST")
            {
                ViewBag.Type = "Radio";
                ViewBag.Name = "Month";
                ViewBag.Value = State;
                return View("Result");
            }
            else return View();
        }
       

        public IActionResult DropDownList(string State)
        {
            if (Request.Method == "POST")
            {
                ViewBag.Type = "Drop-Down List";
                ViewBag.Name = "Month";
                ViewBag.Value = State;
                return View("Result");
            }
            else return View();
        }


        public IActionResult ListBox(string State)
        {
            if (Request.Method == "POST")
            {
                ViewBag.Type = "List Box";
                ViewBag.Name = "Month";
                ViewBag.Value = State;
                return View("Result");
            }
            else return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}