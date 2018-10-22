using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramHandin2
{
    public class AllCustomers
    {
        private List<Customer> all;

        public AllCustomers()
        {
            all = new List<Customer>();
        }

        public void AddCustomer(Customer c)

        {
            all.Add(c);
        }

        public List<Customer> WhatIsInside()
        {
            return all;
        }
    }
}