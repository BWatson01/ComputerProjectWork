using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
namespace FrontEnd
{
    public partial class AnCustomer : System.Web.UI.Page
    {


        Int32 CustomerNo;

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
            if (IsPostBack == false)
    
                {

             
                {
                    DisplayCustomer();
                }

                }
            
        }

       





        void Add()
        {
            Class_Library.clsCustomerCollection CustomerBook = new clsCustomerCollection();
            String Error = CustomerBook.ThisCustomer.Valid(txtCustomerName.Text, txtCustomerAddress.Text, txtPhoneNumber.Text, txtPostCode.Text);
            if (Error == "")
            {
                CustomerBook.ThisCustomer.CustomerName = txtCustomerName.Text;
                CustomerBook.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
                CustomerBook.ThisCustomer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                CustomerBook.ThisCustomer.CustomerPostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.Active = txtActive.Checked;

                CustomerBook.Add();
                Response.Redirect("AnCustomer.aspx");
            }
            else
            {
                lblError.Text = "There were problems with the data entered " + Error;
            }

        }



        protected void Button2_Click(object sender, EventArgs e)       
        {
            if (CustomerNo == -1)
            {
                Add();
            }
            else
            {
                Update();
                Response.Redirect("Customer.aspx");
            }
          

            }
        





        void Update()
        {

            clsCustomerCollection CustomerBook = new clsCustomerCollection();

            string Error = CustomerBook.ThisCustomer.Valid(txtCustomerName.Text, txtCustomerAddress.Text, txtPhoneNumber.Text, txtPostCode.Text);
            if (Error == "")
            {
                CustomerBook.ThisCustomer.Find(CustomerNo);
                CustomerBook.ThisCustomer.CustomerName = txtCustomerName.Text;
                CustomerBook.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
                CustomerBook.ThisCustomer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                CustomerBook.ThisCustomer.CustomerPostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.Active = txtActive.Checked;

                CustomerBook.Update();
                Response.Redirect("AnCustomer.aspx");
            }
            else
            {
                lblError.Text = "There were problems with the data entere " + Error;
            }

        }

        void DisplayCustomer()
        {
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ThisCustomer.Find(CustomerNo);

            txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
            txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber.ToString();
            txtPostCode.Text = CustomerBook.ThisCustomer.CustomerPostCode;
            txtActive.Checked = CustomerBook.ThisCustomer.Active;
            txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}

