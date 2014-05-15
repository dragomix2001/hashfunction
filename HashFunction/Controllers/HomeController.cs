using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using HashFunction.Models;
using System.Threading;

namespace HashFunction.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String text)
        {
            String hash = PasswordHash.CreateHash("Gavra");
            Thread.Sleep(2000);
            ViewBag.hashf = PasswordHash.ValidatePassword(text, hash);
            return View();
        }

    }
}
