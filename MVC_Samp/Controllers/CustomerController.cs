using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using MVC_Samp.Models;
namespace MVC_Samp.Controllers
{
    public class CustomerController : Controller
    {
        CustData data = new CustData();
        // GET: Customer
        public ActionResult test()
        {
            return View();
        }
        public ActionResult Index()
        {
            
            return View(data.GetAll());
        }

        protected  override void OnException(ExceptionContext filtercontext)
        {



        }

        public ActionResult Customer(int id)
        {
           // int id = int.Parse(Request.QueryString["id"]);
            var cust = data.getByID(id);
            return View(cust);
        }

        [HttpPost]
        public ActionResult AddCustomer(CUSTOMER cust)
        {
            data.Addcustomer(cust.ID, cust.AGE, cust.SALARY, cust.ADDRESS, cust.NAME);
           return Redirect("Index");
          //  return View("Index", data.GetAll());
        }

        public ActionResult AddCustomer()
        {
            //data.Addcustomer(cust.ID, cust.AGE, cust.SALARY, cust.ADDRESS, cust.NAME);
            return View();
        }

    }
}