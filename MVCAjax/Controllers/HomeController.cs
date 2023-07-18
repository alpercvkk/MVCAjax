using Microsoft.AspNetCore.Mvc;
using MVCAjax.Data;
using MVCAjax.Models;
using System.Diagnostics;

namespace MVCAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var db = new AppDbContext();
            var plist = db.Products.ToList();
            return View(plist);
        }

        [HttpPost]
        public IActionResult Like ( [FromBody]string id)
        {
           
            

            try
            {
                var db = new AppDbContext();
                var p = db.Products.Find(id);
                p.Liked = !p.Liked;
                db.SaveChanges();

                return Json(new { liked = p.Liked, isSuccess = true }); // classsız object anonim tip


            }
            catch (Exception)
            {

                return Json
                    (new { isSuccess = false });
            }

           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}