using Microsoft.AspNetCore.Mvc;
using System;

namespace Time_Display.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public ViewResult Index()
        {
            DateTime current = DateTime.Now;
            ViewBag.CurrentDate = current.ToString("MMM dd, yyyy");
            ViewBag.CurrentTime = current.ToString("h:mm tt");
            return View("Index");
        }
    }
}