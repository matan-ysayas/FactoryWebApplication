using FactoryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowEmployeeName()
        {

            string employeeName = "bob";

            ViewBag.EmployeeName = employeeName;

            return View();
        }


        public ActionResult ShowEmployee()
        {
            return View();
        }

        public ActionResult ShowEmployeesNames()
        {
            string[] employeesNames = new string[] { "matan", "lior", "haim", "marcos", "ben","yosi" };

            ViewBag.EmployeeNames = employeesNames;

            return View();
        }


        public ActionResult ShowEmployees()
        {
            return View();
        }

        public ActionResult EmployeeOjb()
        {

            Employee employee = new Employee("matan","ysayas",1996,"08542154");

           

            return View(employee);

        }


        public ActionResult EmployeeList()
        {
            List <Employee>  employeesList = new List<Employee>(6);
            employeesList.Add(new Employee("rob", "avi", 1996, "8558787"));
            employeesList.Add(new Employee("haim", "yosi", 1995, "55656"));
            employeesList.Add(new Employee("sdsd,", "sdsds", 2000, "8975454"));
            employeesList.Add(new Employee("eeee", "sdsd", 1998, "777777"));
            employeesList.Add(new Employee("eewewe,", "swewe", 2013, "8975454"));
            employeesList.Add(new Employee("eeee", "sdsd", 1969, "96968857"));


            return View(employeesList);
        }


    }
}