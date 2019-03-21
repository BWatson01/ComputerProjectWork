using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
namespace FrontEnd
{
    public partial class Order : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //display all phones
                DisplayOrders("");
            }
        }


        Int32 DisplayOrders(string CustomerNameFilter)
        {
            Int32 OrderNo;//var to store the primary key
            String CustomerName; //var to store the Device Name
            String ItemName; //var to store the Device Name
            Int32 Invoice;//var to store the primary key
            ;//create an instance of the phone class
            clsOrderCollection Order = new clsOrderCollection();
            Order.ReportByCustomerName(CustomerNameFilter);
            Int32 RecordCount;//var to store the count of records
            Int32 Index = 0;//var to store the index for the loop
            RecordCount = Order.Count;// get the count of records
            lstOrders.Items.Clear(); //clear the list box
            while (Index < RecordCount)//while there are records to process
            {
                OrderNo = Order.OrderList[Index].OrderNo;//get the primary key
                CustomerName = Order.OrderList[Index].CustomerName; //get the Device Name
                ItemName = Order.OrderList[Index].ItemName; //get the Operating System
                Invoice = Order.OrderList[Index].Invoice; //get the Price
                                                                 //create a new entry for the list box
                ListItem NewEntry = new ListItem(CustomerName + ", " + ItemName + ", " + Invoice, OrderNo.ToString());
                lstOrders.Items.Add(NewEntry);//add the phone to the list
                Index++;//move the index to the next record
            }
            return RecordCount;//return the count of the records found
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // sttore -1 into the session object to indicate this is a new record
            Session["OrderNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnOrder.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            //var to store the primary key value
            Int32 OrderNo;
            if (lstOrders.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
                //store the data in the sessions object
                Session["OrderNo"] = OrderNo;
                //redirect to the Delete page
                Response.Redirect("Delete.aspx?OrderNo=" + OrderNo);
            }
            else
            {
                //display an error
                lblError.Text = "You must select an Order off the list first in order to delete.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 OrderNo;
            if (lstOrders.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
                //store the data in the sessions object
                Session["OrderNo"] = OrderNo;
                //redirect to the editing page
                Response.Redirect("AnOrder.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "You must select an Order off the list first to edit it.";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only Orders mattching the text in the Customer Name text box
            DisplayOrders(txtSearchBar.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all phones
            DisplayOrders("");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            //redirect to the editing page
            Response.Redirect("HomePage.aspx");
        }
    }
}