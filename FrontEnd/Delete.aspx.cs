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
        //var to store the orimary key value of te record to be deleted
        Int32 ManufacturerId;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of orders to be deleted from the sessions object
            ManufacturerId = Convert.ToInt32(Session["ManufacturerId"]);
            //if this is not an instruction to add a new record
            if (ManufacturerId != -1)
            {
                if (IsPostBack != true)
                {
                    //display the existing data
                    DeleteManufacturer(ManufacturerId);
                }
            }
        }

        //event handler for the yes button
        protected void Button2_Click()
        {

        }

        protected void btnYes_Click(object sender, EventArgs e)
        {

        }
        void DeleteManufacturer(Int32 ManufacturerId)
        {
            //function to delete the selected record

            //create a a new instance of the collection class
            clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
            //find the record to delete 
            Manufacturer.ThisManufacturer.Find(ManufacturerId);
            //display the PhoneID
            lblError.Text = "Are you sure that you want to Delete this Manufacturer off the system?";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //create a a new instance of the collection class
            clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
            //declare a variable to store the PhoneID to delete

            //declare a boolean variable to record success of the delete operation
            Boolean Found;
            //try and find the record to delete
            Found = Manufacturer.ThisManufacturer.Find(ManufacturerId);
            //if the record is found
            if (Found)
            {
                //invoke the delete method of the object
                Manufacturer.Delete();
            }
            Response.Redirect("Manufacturer.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Manufacturer.aspx");
        }
    }
}