using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.ViewModels;

namespace WebApplication5.Controllers

{
    public class CustomersController : Controller
    {



        //[Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View(this.GetCustomers());
        }

        private RandomMovieViewModel GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
            var customersView = new RandomMovieViewModel
            {
                Customers = customers
            };
            return customersView;
        }

    }
}