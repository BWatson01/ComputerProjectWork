using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
namespace FrontEnd
{
    public partial class Delete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderNo;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of orders to be deleted from the sessions object
            OrderNo = Convert.ToInt32(Session["OrderNo"]);
            //if this is not an instruction to add a new record
            if (OrderNo != -1)
            {
                if (IsPostBack != true)
                {
                    //display the existing data
                    DeleteOrder(OrderNo);
                }
            }
        }


        void DeleteOrder(Int32 OrderNo)
        {
            //function to delete the selected record

            //create a a new instance of the collection class
            clsOrderCollection Orders = new clsOrderCollection();
            //find the record to delete 
            Orders.ThisOrder.Find(OrderNo);
            //display the PhoneID
            lblDelete.Text = "Are you sure that you want to Delete this Order off the system?";
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //create an instance of the class clsPhone called MyPhones
            clsOrderCollection MyOrder = new clsOrderCollection();
            //declare a variable to store the PhoneID to delete

            //declare a boolean variable to record success of the delete operation
            Boolean Found;
            //try and find the record to delete
            Found = MyOrder.ThisOrder.Find(OrderNo);
            //if the record is found
            if (Found)
            {
                //invoke the delete method of the object
                MyOrder.Delete();
            }
            Response.Redirect("Default.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Order.aspx");
        }
    }
}