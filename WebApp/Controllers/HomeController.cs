using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IConfigService ConfigService { get; set; }

        public HomeController(IConfigService configService)
        {
            this.ConfigService = configService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if (this.ConfigService.FeatureFlag.IsAvailable("Feature02"))
            {
                ViewBag.Message = "Feature02 is available";
            }
            else
            {
                ViewBag.Message = "Feature02 is not available";
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}