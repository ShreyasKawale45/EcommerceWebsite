using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebsite.Controllers.Blogs
{
    public class BlogsController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogInfo()
        {
            return View();
        }
    }
}
