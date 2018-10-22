using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramHandin2
{
    public class Customer
    {
        
        private string Name;
        private int Age;
        private int Zip;
        private string Password;
        public string Region;

        public Customer(string CustomerName, int CustomerAge, int CustomerZip, string CustomerPassword, string CustomerRegion)
        {
            this.Name = CustomerName;
            this.Age = CustomerAge;
            this.Zip = CustomerZip;
            this.Password = CustomerPassword;
            this.Region = CustomerRegion;
        }

        public override string ToString()
        {
            return "NAME: " + Name + " AGE: " + Age + " ZIP: " + Zip + " PASSWORD: " + Password + " REGION: " + Region;
        }
    }
}