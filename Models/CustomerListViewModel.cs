using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Entities;

namespace AspNetCore.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customer { get; set; }
        public List<string> sehirler { get; set; }

        }
}
