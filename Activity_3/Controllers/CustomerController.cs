using Activity_3.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Activity_3.Controllers
{
    public class CustomerController : Controller
    {
        // CustomerModel customer;

        List<CustomerModel> customers { get; set; }
        // { get; set; }

        public CustomerController()
        {
            customers = new List<CustomerModel>();
            customers.Add(new CustomerModel(0, "Nick", 10));
            customers.Add(new CustomerModel(1, "Martin", 20));
            customers.Add(new CustomerModel(2, "Brian", 30));
            customers.Add(new CustomerModel(3, "Kurt", 40));
            customers.Add(new CustomerModel(4, "Isaac", 50));
            customers.Add(new CustomerModel(5, "Professor", 60));
        }

        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);

            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(CustomerNumber)]);

            // No AJAX
           // return View("Customer", tuple);

            // AJAX
            return PartialView("_CustomerDetails", customers[Int32.Parse(CustomerNumber)]);
        }

        // AJAX JavaScript callback handler
        [HttpPost]
        public string GetMoreInfo(string customerID)
        {
            return customerID;
        }

    }
}
