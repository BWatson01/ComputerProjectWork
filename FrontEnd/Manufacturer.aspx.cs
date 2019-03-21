using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
namespace FrontEnd
{
    public partial class Manufacturer : System.Web.UI.Page
    {

        protected void Page_Load(object sender,EventArgs e)
        {
            //if this is the first time page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayManufacturers("");
            }
        }

        Int32 DisplayManufacturers(string ManufacturerNameFilter)
        {
            Int32 ManufacturerId;//var to store the primary key
            String ManufacturerName; //var to store the Device Name
            String Address; //var to store the Device Name
            Int32 Telephone;//var to store the primary key
            String EmailAddress;//
            ;//create an instance of the phone class
            clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
            Manufacturer.ReportByManufacturerName(ManufacturerNameFilter);
            Int32 RecordCount;//var to store the count of records
            Int32 Index = 0;//var to store the index for the loop
            RecordCount = Manufacturer.Count;// get the count of records
            lstManufacturers.Items.Clear(); //clear the list box
            while (Index < RecordCount)//while there are records to process
            {
                ManufacturerId = Manufacturer.ManufacturerList[Index].ManufacturerId;//get the primary key
                ManufacturerName = Manufacturer.ManufacturerList[Index].ManufacturerName; //get the Device Name
                Address = Manufacturer.ManufacturerList[Index].Address; //get the Operating System
                Telephone = Manufacturer.ManufacturerList[Index].Telephone; //get the Price
                EmailAddress = Manufacturer.ManufacturerList[Index].EmailAddress;//get email address                                        
                ListItem NewEntry = new ListItem(ManufacturerName + ", " + Telephone.ToString() + ", " + Address + ",", ManufacturerId.ToString());
                lstManufacturers.Items.Add(NewEntry);//add the phone to the list
                Index++;//move the index to the next record
            }
            return RecordCount;//return the count of the records found
        }

     

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
        //event handler for the add button
        protected void Button3_Click(object sender, EventArgs e)
        {
            {
                // sttore -1 into the session object to indicate this is a new record
                Session["ManufacturerId"] = -1;
                //redirect to the data entry page
                Response.Redirect("AnManufacturer.aspx");
            }
        }
       

        protected void btnError_Click(object sender, EventArgs e)
        {

        }
        //event handler for the edit button
       
        

        protected void Button5_Click(object sender, EventArgs e)
        {
            {
                //var to store the primary key value of the record to  be edited
                Int32 ManufacturerId;
                //if a record has been selected from the list
                if (lstManufacturers.SelectedIndex != -1)
                {
                    //get the primary key value of the record to edit
                    ManufacturerId = Convert.ToInt32(lstManufacturers.SelectedValue);
                    //store the data in the session object
                    Session["ManufacturerId"] = ManufacturerId;
                    //redirect tpo the edit page
                    Response.Redirect("AnManufacturer.aspx");

                }
                else
                //if no record has been selected
                {
                    //display an error
                    lblError.Text = "Please select a record to delete from the list";
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            //var to store the primary key value
            Int32 ManufacturerId;
            if (lstManufacturers.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                ManufacturerId = Convert.ToInt32(lstManufacturers.SelectedValue);
                //store the data in the sessions object
                Session["ManufacturerId"] = ManufacturerId;
                //redirect to the Delete page
                Response.Redirect("Delete.aspx?ManufacturerId=" + ManufacturerId);
            }
            else
            {
                //display an error
                lblError.Text = "You must select a Manufacturer off the list first in order to delete.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 ManufacturerId;
            if (lstManufacturers.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                ManufacturerId = Convert.ToInt32(lstManufacturers.SelectedValue);
                //store the data in the sessions object
                Session["ManufacturerId"] = ManufacturerId;
                //redirect to the editing page
                Response.Redirect("AnManufacturer.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "You must select a Manufacturer off the list first to edit it.";
            }
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            //display only Orders mattching the text in the Customer Name text box
            DisplayManufacturers(TextBox.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //display all phones
            DisplayManufacturers("");
        }
    }
}