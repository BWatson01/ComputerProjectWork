using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Class_Library;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        Int32 CustomerNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        }

        void DeleteCustomers()
        {

            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ThisCustomer.Find(CustomerNo);
            CustomerBook.Delete();
        }


        protected void btnYes_Click(object sender, EventArgs e)
        {
            DeleteCustomers();
            Response.Redirect("Customer.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}