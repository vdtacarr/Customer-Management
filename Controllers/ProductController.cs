using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Entities;
using AspNetCore.Models;
namespace AspNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            List<Customer> customers = new List<Customer> { 
            new Customer{Id=1,FirstName = "vedat", LastName = "acar",City= "bursa" },
            new Customer{Id=2,FirstName = "vedat2", LastName = "acar",City= "bursa" },
            new Customer{Id=3,FirstName = "vedat3", LastName = "acar",City= "bursa" },

            };
            List<string> sehirler = new List<string> { "İstanbul", "Ankara", "İzmir" };
            var model = new CustomerListViewModel{
                Customer = customers,
                sehirler = sehirler
            };
            return View(model);
        }
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel());
        }
    }

}
