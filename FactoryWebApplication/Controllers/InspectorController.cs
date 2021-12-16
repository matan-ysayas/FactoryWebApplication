using FactoryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryWebApplication.Controllers
{
    public class InspectorController : Controller
    {
        // GET: Inspector
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ShowInspectorName()
        {
            string inspectorName = "avi";
            ViewBag.InspectorName = inspectorName;
            return View();
        }
        public ActionResult ShowInspector()
        {
            return View();
        }
        public ActionResult GetAllInspectorsNames()
        {
            string[] inspectorsNames = new string[] { "wsds", "ronu", "youda", "masn", "yas", "wewe" };
            ViewBag.InspectorsNames = inspectorsNames;
            return View();
        }

        public ActionResult GetAllInspectors()
        {
            return View();
        }
         
        public ActionResult InspectorOjb()
        {
            Inspector inspector = new Inspector("matan", "ysayas", 1996, 6);
            return View(inspector);
        }

        public ActionResult InspectorList() {
            
                List <Inspector> inspectorsList=new List<Inspector>();
            inspectorsList.Add(new Inspector("bob", "sdsd", 1585, 5));
            inspectorsList.Add(new Inspector("dfb", "sdsd", 1785, 7));
            inspectorsList.Add(new Inspector("bobi", "eeeed", 1655, 9));
            inspectorsList.Add(new Inspector("avner", "sdsd", 1985,7));
            return View(inspectorsList); 
        }

    }
}