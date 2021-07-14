using AspNetCore.Entities;
using AspNetCore.Models;
using AspNetCore.Services.logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    [Route(template: "deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;
        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }
        
        [Route(template: "index")]
        public IActionResult Index2()
        {
            _logger.Log("");
            List<Customer> customers = new List<Customer> {
            new Customer{Id=1,FirstName = "vedat", LastName = "acar",City= "bursa" },
            new Customer{Id=2,FirstName = "vedat2", LastName = "acar",City= "bursa" },
            new Customer{Id=3,FirstName = "vedat3", LastName = "acar",City= "bursa" },

            };
            List<string> sehirler = new List<string> { "İstanbul", "Ankara", "İzmir" };
            var model = new CustomerListViewModel
            {
                Customer = customers,
                sehirler = sehirler
            };
            return View(model);
        }
            [HttpGet]
            public IActionResult SaveCustomer()
            {
                return View(new SaveCustomerViewModel { 
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06"},
                    new SelectListItem{Text="İstanbul",Value="34"},
                    new SelectListItem{Text="İzmir",Value="035"}

                }
                });
            }
        [HttpPost]
            public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
           
        }

    }

