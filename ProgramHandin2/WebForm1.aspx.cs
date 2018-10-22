using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramHandin2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private AllCustomers rolodex;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["SharedRolodex"] == null)
            {
                Application["SharedRolodex"] = new AllCustomers();
            }

            rolodex = (AllCustomers)Application["SharedRolodex"];
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(
                TextBoxName.Text,
                Int32.Parse(TextBoxAge.Text),
                Int32.Parse(TextBoxZip.Text),
                TextBoxPass.Text,
                TextBoxRegion.Text);


            rolodex = (AllCustomers)Application["SharedRolodex"];
            rolodex.AddCustomer(c);
            Application["SharedRolodex"] = rolodex;
            Application.UnLock();

          //  UpdateCustomerListView();
        }

        private void UpdateCustomerListView()
        {
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInRolodex = rolodex.WhatIsInside();
            foreach (Customer c in CustomersInRolodex)
            {

                ListBoxCustomers.Items.Add(c.ToString());
                

            }

        }

        protected void ButtonJutland_Click(object sender, EventArgs e)
        {
             ListBoxCustomers.Items.Clear();

                List<Customer> CustomersInRolodex = rolodex.WhatIsInside();
                foreach (Customer c in CustomersInRolodex)
                {
                if (c.Region == "Jutland")
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
                    
                }

            
        }

        

        protected void ButtonFunen_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInRolodex = rolodex.WhatIsInside();
            foreach (Customer c in CustomersInRolodex)
            {
                if (c.Region == "Funen")
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }

            }
        }

        protected void ButtonZealand_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInRolodex = rolodex.WhatIsInside();
            foreach (Customer c in CustomersInRolodex)
            {
                if (c.Region == "Zealand")
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }

            }
        }

        protected void ButtonAll_Click(object sender, EventArgs e)
        {
            UpdateCustomerListView();
        }
    }
}