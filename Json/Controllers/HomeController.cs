using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Json.Models;

namespace Json.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Json");
        }

        public JsonResult getModel()
        {
            ModelObj json = new ModelObj();
            return Json(json.getModelObj(), JsonRequestBehavior.AllowGet);
        }
    }
}