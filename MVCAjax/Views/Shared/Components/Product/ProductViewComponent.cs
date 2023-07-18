using Microsoft.AspNetCore.Mvc;
using MVCAjax.Data;
using MVCAjax.Data.Entities;
namespace MVCAjax.Views.Shared.Components.Product
{
    public class ProductViewComponent :ViewComponent
    {

        public IViewComponentResult Invoke(bool? liked = null)
        {
            var db = new AppDbContext();


            if (liked == null)
            {
                var plist = db.Products.OrderBy(x => x.Name).ToList();
                return View(plist);
            }

            else
            {
                var plist = db.Products.Where(x => x.Liked == liked).OrderBy(x => x.Name).ToList();

                return View(plist);
            }
        }
    }
}
