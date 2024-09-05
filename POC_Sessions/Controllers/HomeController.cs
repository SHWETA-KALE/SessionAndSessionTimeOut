using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC_Sessions.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["MyTimeSession"] = DateTime.Now.ToString();
            TempData["MyData"] = DateTime.Now.ToString();
            //ViewData["MyData"] = DateTime.Now.ToString();
            //return View();
            return RedirectToAction("Home");
        }

        public ActionResult Home()
        {
            //ViewData["MyData"] = DateTime.Now.ToString();
            //using viewbag
            //ViewBag.MyTime = DateTime.Now.ToString();
            return View();
        }

        public ActionResult DemonstrationSession()
        {
            return View();
        }

    }
}















//viewbag is just a syntactic sugar of viewdata both are used for passing data from controller to view
//viewbag or viewdata does not maintain the data from controller to controller or from one action method to another action method hence w use
//temp data for that
//temp data is only for one req from action to action or action to view
//view bag is dyanamic it perform internal reflection