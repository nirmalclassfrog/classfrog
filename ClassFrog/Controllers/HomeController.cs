using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassFrog.Controllers
{
    /// <summary>
    /// Home controller for all static pages including home page
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ViewResult for home page</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Miscs this instance.
        /// </summary>
        /// <returns>View result for static pages</returns>
        [HttpGet]
        public ActionResult Misc()
        {
            return View();
        }
    }
}
