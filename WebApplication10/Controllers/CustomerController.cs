using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customers = new List<Customer>();
            {
                customers.Add(new Customer() { CustomerID = 34, CustomerName = "neela", CustomerAddresss = "khammam" });
                customers.Add(new Customer() { CustomerID = 678, CustomerName = "krishna", CustomerAddresss = "hyderabad" });
                customers.Add(new Customer() {CustomerID = 456, CustomerName = "kousik", CustomerAddresss = "vijayawada" });
                ViewData["customers"] = customers;


            }

            return View();
        }
    }
}
