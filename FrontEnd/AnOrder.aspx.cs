using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
namespace FrontEnd
{
    public partial class AnOrder : System.Web.UI.Page
    {
        //var to store the PhoneID
        Int32 OrderNo;

        protected void Page_Load(object sender, EventArgs e)
        {
            //copy the data from the query string to the text box txtPhoneID
            OrderNo = Convert.ToInt32(Session["OrderNo"]);
            //if this is not an instruction to add a new record

            if (IsPostBack == false)
            {
               if (OrderNo != -1)
               {
                  // display the existing data
                    DisplayOrders(OrderNo);
               }
           }
        }



        //function for adding new records
        void Add()
        {
            //create an instance of the OrderCollection class
            clsOrderCollection Orders = new clsOrderCollection();
            //validate the data on the web form
            String Error = Orders.ThisOrder.Valid(txtComputerNo.Text, txtCustomerNo.Text, txtItemName.Text, txtCustomerName.Text, txtInvoice.Text, txtDeliveryDate.Text, txtOrderDate.Text, ddlStatus.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //copy the data from the interface to the object
                Orders.ThisOrder.ComputerNo = Convert.ToInt32(txtComputerNo.Text);
                Orders.ThisOrder.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
                Orders.ThisOrder.ItemName = txtItemName.Text;
                Orders.ThisOrder.CustomerName = txtCustomerName.Text;
                Orders.ThisOrder.Invoice = Convert.ToInt32(txtInvoice.Text);
                Orders.ThisOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
                Orders.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                Orders.ThisOrder.Status = ddlStatus.Text;
                //add the new record
                Orders.Add();
                //all done so redirect back to the main page
                Response.Redirect("Order.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }


        }


        void Update()
        {
            //create an instance of the OrderCollection class
            clsOrderCollection Orders = new clsOrderCollection();
            //validate the data on the web form
            String Error = Orders.ThisOrder.Valid(txtComputerNo.Text, txtCustomerNo.Text, txtItemName.Text, txtCustomerName.Text, txtInvoice.Text, txtDeliveryDate.Text, txtOrderDate.Text, ddlStatus.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                Orders.ThisOrder.Find(OrderNo);
                //get the data entered by the user
                Orders.ThisOrder.ComputerNo = Convert.ToInt32(txtComputerNo.Text);
                Orders.ThisOrder.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
                Orders.ThisOrder.ItemName = txtItemName.Text;
                Orders.ThisOrder.CustomerName = txtCustomerName.Text;
                Orders.ThisOrder.Invoice = Convert.ToInt32(txtInvoice.Text);
                Orders.ThisOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
                Orders.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                Orders.ThisOrder.Status = ddlStatus.Text;
                //update the new record
                Orders.Update();
                //all done so redirect back to the main page
                Response.Redirect("Order.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }


        }



        void DisplayOrders(Int32 OrderNo)
        {
            //create an instance of the phone class
            clsOrderCollection Orders = new clsOrderCollection();
            //find the record we want to display
            Orders.ThisOrder.Find(OrderNo);
            //display the house no
            txtComputerNo.Text = Orders.ThisOrder.ComputerNo.ToString();
            txtCustomerNo.Text = Orders.ThisOrder.CustomerNo.ToString();
            txtItemName.Text = Orders.ThisOrder.ItemName;
            txtCustomerName.Text = Orders.ThisOrder.CustomerName;
            txtInvoice.Text = Orders.ThisOrder.Invoice.ToString();
            txtDeliveryDate.Text = Orders.ThisOrder.DeliveryDate.ToString("dd/mm/yyyy");
            txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString("dd/mm/yyyy");
            ddlStatus.Text = Orders.ThisOrder.Status.ToString();
        }



        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (OrderNo == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Order.aspx");
        }
    }
}