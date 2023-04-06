using System.Linq;
using System.Web.Mvc;
using Webbanhang.Context;

namespace Webbanhang.Controllers
{
    public class ProductController : Controller
    {
        trung_webEntities1 objtrung_webEntities = new trung_webEntities1();
        // GET: Product
        public ActionResult Detail(int Id)
        {
            var objProduct = objtrung_webEntities.Products.Where(n => n.Id == Id).FirstOrDefault();
            return View(objProduct);
        }
    }
}