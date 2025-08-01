using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebsite.Controllers.Product
{
    public class ProductController : Controller
    {
        public IActionResult AllProducts()
        {
            return View();
        }
    }
}
