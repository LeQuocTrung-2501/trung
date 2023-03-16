using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbanhang.Context;

namespace Webbanhang.Controllers
{
    public class ProductController : Controller
    {
        webbanhangEntities objwbhEntities = new webbanhangEntities();
        // GET: Product
        public ActionResult Detail(int id)
        {
            var objProduct = objwbhEntities.Products.Where(n => n.Id == id).FirstOrDefault();
            return View(objProduct);

        }
    }
}
