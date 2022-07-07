using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers list
        [Route("customers")]
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        // GET: Customer details
        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var model = new Customer() { Name = "Cameron Vincent", Id = 1 };

            return View(model);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Name="Cameron Vincent", Id=1},
                new Customer {Name="Larissa Gilbert", Id=2}
            };
        }
    }
}