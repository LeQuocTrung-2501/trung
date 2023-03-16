using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbanhang.Context;
using Webbanhang.Models;

namespace Webbanhang.Controllers
{

    public class HomeController : Controller
    {
        webbanhangEntities objwbhEntities = new webbanhangEntities();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            objHomeModel.ListCategory = objwbhEntities.Categories.ToList();
            objHomeModel.ListProduct = objwbhEntities.Products.ToList();
            return View(objHomeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}