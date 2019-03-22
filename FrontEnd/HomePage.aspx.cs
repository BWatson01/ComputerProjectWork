using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            //redirect to the Order page
            Response.Redirect("Order.aspx");
        }

        protected void btnComputers_Click(object sender, EventArgs e)
        {
            //redirect to the Manufacturer PAGE
            Response.Redirect("Default.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //redirect to the Manufacturer PAGE
            Response.Redirect("Customer.aspx");
        }

        protected void btnManufacturer_Click(object sender, EventArgs e)
        {
            //redirect to the Manufacturer PAGE
            Response.Redirect("Manufacturer.aspx");
        }
    }
}