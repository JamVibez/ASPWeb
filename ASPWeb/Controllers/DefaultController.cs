using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPWeb.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult one()
        {
            return View();
        }

		public string Text()
		{
			return "Raz";
		}
    }
}