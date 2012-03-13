using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidwestGeeks.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/

        public ActionResult Index()
        {
            dynamic weeklyEvents = new List<dynamic>()
                                       {
                                           new { 
                                               Name = "Chicago Alt.Net",
                                               Date = new DateTime(2012, 3, 14).ToLongDateString(),
                                               StartTime = "6:00pm",
                                               Location = "SPR/Redpoint Technologies",
                                               Address = "233 South Wacker Dr, 35th Floor",
                                               City = "Chicago",
                                               State = "Illinois",
                                               ZipCode = "60606",
                                               WebsiteUrl = "www.chicagoalt.net"
                                           },
                                           new { 
                                               Name = "angleBracket",
                                               Date = new DateTime(2012, 3, 15).ToLongDateString(),
                                               StartTime = "7:00pm",
                                               Location = "College of Lake County",
                                               Address = "19351 West Washington",
                                               City = "Grayslake",
                                               State = "Illinois",
                                               ZipCode = "60030",
                                               WebsiteUrl = "www.anglebracket.net"
                                           },
                                           new { 
                                               Name = "Lcnug",
                                               Date = new DateTime(2012, 4, 12).ToLongDateString(),
                                               StartTime = "7:00pm",
                                               Location = "College of Lake County",
                                               Address = "19351 West Washington",
                                               City = "Grayslake",
                                               State = "Illinois",
                                               ZipCode = "60030",
                                               WebsiteUrl = "www.lcnug.org"
                                           }

                                       };

            return Json(new {results = weeklyEvents }, JsonRequestBehavior.AllowGet);
        }

    }
}
