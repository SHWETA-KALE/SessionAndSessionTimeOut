using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC_Sessions.Controllers
{
    public class SessionTimeoutController : Controller
    {
        // GET: Sessiontimeout
        public ActionResult Index()
        {
            //setting session data 
            Session["UserName"] = "Shweta Kale";

            //setting session timeout to 1 min for demonstration
            Session.Timeout = 1;
            return View();
        }

        public ActionResult CheckSession()
        {
            if (Session["UserName"] != null)
            {
                ViewBag.Message = $"Session is active. User:{Session["UserName"]}";
            }
            else
            {
                ViewBag.Message = "Session has expired.";
            }

            return View();
        }
    }
}