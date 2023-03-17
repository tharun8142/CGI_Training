using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace WebApplication1.Controllers
{
    public class GoldController : Controller
    {
        public IActionResult List()
        {
            /*ContentResult cr = new ContentResult();
            cr.ContentType= "text/html";
            cr.Content = "<h1>Hello World</h1>";
            return cr;*/
            return View();
        }
    }
}
