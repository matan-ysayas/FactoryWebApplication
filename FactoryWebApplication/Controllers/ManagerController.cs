using FactoryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryWebApplication.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ShowManagerName()
        {
            string managerName = "rob";
            ViewBag.ManagerName = managerName;
            return View();
        }
        public ActionResult ShowManager()
        {
            return View();
        }
        public ActionResult GetAllManagersNames()
        {
            string[] managersNames = new string[] { "avi", "ronu", "yoni", "matan", "yosi", "avner" };
            ViewBag.ManagersNames = managersNames;
            return View();
        }

        public ActionResult GetAllManagers()
        {
            return View();
        }

        public ActionResult ManagerOjb() {
            Manager manager = new Manager("rob","you","web");
            return View(manager); 
          }



        public ActionResult ManagerList() { 
        
            List<Manager> list = new List<Manager>();
            list.Add(new Manager("vova", "asas", "asas"));
            list.Add(new Manager("eee", "erdfs", "dfdfas"));
            list.Add(new Manager("touda", "sdsds", "sdsdsdsd"));

            return View(list);
        
        }
    }
}