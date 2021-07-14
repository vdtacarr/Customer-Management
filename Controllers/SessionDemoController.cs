using AspNetCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Extensions;
namespace AspNetCore.Controllers
{
    public class SessionDemoController:Controller
    {
        
        public string Index1()
        {
            Customer customer = new Customer { Id = 1, FirstName = "vedat" };
            HttpContext.Session.SetObject("musteri", customer);
            return "session kaydedildi";
        }
        public string Index2()
        {
            var customer =  HttpContext.Session.GetObject<Customer>("musteri");
            return customer.FirstName;
        }
    }
}
