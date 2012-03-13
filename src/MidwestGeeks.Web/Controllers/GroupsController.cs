using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidwestGeeks.Controllers
{
    public class GroupsController : Controller
    {
        //
        // GET: /Groups/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            dynamic groups = new List<dynamic>()
                                 {
                                     new {Name = "angleBracket", Pitch = "Super Awesome"},
                                     new {Name = "Lcnug", Pitch = ".Net Nerds"},
                                     new {Name = "Chicago Alt.Net", Pitch = "Hipster .Netters"}
                                 };

            return Json(new {results = groups}, JsonRequestBehavior.AllowGet);
        }

    }
}
