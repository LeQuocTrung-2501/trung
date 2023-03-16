using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbanhang.Context;

namespace Webbanhang.Controllers
{
    public class CategoryController : Controller
    {
        webbanhangEntities objwbhEntities = new webbanhangEntities();
        // GET: Category
        public ActionResult Index()
        {
            var lstCategory = objwbhEntities.Categories.ToList();
            return View(lstCategory);
        }
        public ActionResult ProductCategory(int Id) {
            var lstCategory = objwbhEntities.Products.Where(n=>n.Categoryid==Id).ToList();
            return View(lstCategory);
        }
    }
}