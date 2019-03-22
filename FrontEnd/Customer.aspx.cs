using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Class_Library;

using System.Web.UI.WebControls;
namespace FrontEnd
{
    public partial class Customer : System.Web.UI.Page
    {
       
    Int32 CustomerNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
            if (IsPostBack == false)
            { 
          
                DisplayCustomers();
                
            }
        }


        void DisplayCustomers()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();
            lstCustomer.DataSource = Customers.CustomerList;
            lstCustomer.DataValueField = "CustomerNo";
            lstCustomer.DataTextField = "CustomerName";
            lstCustomer.DataBind();

           
        }

      

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CustomerNo;
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CustomerNo = Convert.ToInt32(lstCustomer.SelectedValue);
                Session["CustomerNo"] = CustomerNo;
                Response.Redirect("Delete.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }

       



        protected void btnEdit2_Click(object sender, EventArgs e)
        {
            Int32 CustomerNo;
            if (lstCustomer.SelectedIndex != -1)
            {
                CustomerNo = Convert.ToInt32(lstCustomer.SelectedValue);
                Session["CustomerNo"] = CustomerNo;
                Response.Redirect("AnCustomer.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";

            }
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            //event handler for the clcik event
            Session["CustomerNo"] = -1;
            Response.Redirect("AnCustomer.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
        }

       
    }
}