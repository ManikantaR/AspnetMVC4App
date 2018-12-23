using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMVC4App.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Register()
        {
            return View();

        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
    }
}