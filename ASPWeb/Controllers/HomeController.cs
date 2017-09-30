using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPWeb.Models;

namespace ASPWeb.Controllers
{
	public class HomeController : Controller
    {

        private ServicesDBContext db = new ServicesDBContext();
        public ActionResult Index()
		{
			return View();
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

        public ActionResult Services()
        {
            return View(db.Services.ToList());
        
        ViewBag.Message = "Your services page.";

            return View();
        }

        public ActionResult Order()
        {
            ViewBag.Message = "Your order page.";

            return View();
        }
    }

}