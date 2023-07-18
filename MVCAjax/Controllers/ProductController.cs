using Microsoft.AspNetCore.Mvc;

namespace MVCAjax.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Filter([FromBody] bool? selectedValue)
        {
            return ViewComponent("Product", new { Liked= selectedValue });
        }
    }
}
