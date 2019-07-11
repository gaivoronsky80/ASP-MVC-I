using Microsoft.AspNetCore.Mvc;
namespace Dojo_Survey.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        
        [HttpGet("")]     
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]     
        public IActionResult Result(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Result");
        }
    }
}