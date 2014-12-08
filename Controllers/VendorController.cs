using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace finaldesign_template.Controllers
{
    public class VendorController : Controller
    {
        //
        // GET: /Vendor/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult pr()//this to be changed and divided in to 3 diferent functions during proper implementation
        {
            return View();
        }
        public ActionResult Purchase_Order()
        {
            return View();
        }
	}
}