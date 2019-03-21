using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
namespace FrontEnd
{
    public partial class AnManufacturer1 : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 ManufacturerId;
        //event handler for the page load event

        protected void Page_Load(object sender, EventArgs e)
        {
            //copy the data from the query string to the text box txtPhoneID
            ManufacturerId = Convert.ToInt32(Session["ManufacturerId"]);
            //if this is not an instruction to add a new record

            if (IsPostBack == false)
            {
                if (ManufacturerId != -1)
                {
                    // display the existing data
                    DisplayManufacturers(ManufacturerId);
                }
            }
        }


        //function for adding new records
        void Add()
        {
            //create an instance ofthr address book
            clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
            //validate the data on the web form
            string Error = Manufacturer.ThisManufacturer.Valid(txtManufacturerName.Text, txtAddress.Text, txtTelephone.Text, txtEmailAddress.Text);
            //if the data i sok then add it to the subject
            if (Error == "")
            {
                //get the data enetered by the user
                Manufacturer.ThisManufacturer.ManufacturerName = txtManufacturerName.Text;
                Manufacturer.ThisManufacturer.Address = txtAddress.Text;
                Manufacturer.ThisManufacturer.Telephone = Convert.ToInt32(txtTelephone.Text);
                Manufacturer.ThisManufacturer.EmailAddress = txtEmailAddress.Text;
                //add the recordd
                Manufacturer.Add();
                //ALL DONE SO REDIRECT back to the main page
                Response.Redirect("Manufacturer.aspx");

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }
        }

        //function for updating records
        void Update()
        {
            //create an instance of the Manufacturer
            clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
            //validate teh data on teh web form
            string Error = Manufacturer.ThisManufacturer.Valid(txtManufacturerName.Text, txtAddress.Text, txtTelephone.Text, txtEmailAddress.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                Manufacturer.ThisManufacturer.Find(ManufacturerId);
                //get the data entered by the uer
                Manufacturer.ThisManufacturer.ManufacturerName = txtManufacturerName.Text;
                Manufacturer.ThisManufacturer.Address = txtAddress.Text;
                Manufacturer.ThisManufacturer.Telephone = Convert.ToInt32(txtTelephone.Text);
                Manufacturer.ThisManufacturer.EmailAddress = txtEmailAddress.Text;
                //update the record
                Manufacturer.Update();
                //all done so redirect back to the main page
                Response.Redirect("Manufacturer.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were propblems with the data entered " + Error;

            }

        }



        void DisplayManufacturers(Int32 ManufacturerId)
        {
            //CREATE AN INSTANCE OF THE Manufacturer
            clsManufacturerCollection Manufacturers = new clsManufacturerCollection();
            //find the record to update
            Manufacturers.ThisManufacturer.Find(ManufacturerId);
            //display teh data for this record
            txtManufacturerName.Text = Manufacturers.ThisManufacturer.ManufacturerName;
            txtAddress.Text = Manufacturers.ThisManufacturer.Address;
            txtTelephone.Text = Manufacturers.ThisManufacturer.Telephone.ToString();
            txtEmailAddress.Text = Manufacturers.ThisManufacturer.EmailAddress;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (ManufacturerId == -1)
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Manufacturer.aspx");
        }
    }
}
