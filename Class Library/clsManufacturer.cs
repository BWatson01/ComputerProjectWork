using System;
using Class_Library;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsManufacturer
    {
        //private data member for the ManufacturerId property
        private Int32 mManufacturerId;
        //private datatmember for ManufacturerName property
        private string mManufacturerName;
        //private data member for Address property
        private string mAddress;
        //private data member for TelephoneNumber property
        private Int32 mTelephone;
        //private data member for Email Address property
        private string mEmailAddress;

        //public property for Email Address
        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }

        //public property for Telephone number
        public int Telephone
        {
            get
            {
                //return the private data
                return mTelephone;
            }
            set
            {
                //set the value of the private data member
                mTelephone = value;
            }
        }

        //public property for Address
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the value of the private data member
                mAddress = value;
            }
        }

        //public property for Manufacturer name
        public string ManufacturerName
        {
            get
            {
                //return the private data
                return mManufacturerName;
            }
            set
            {
                //set the value of the private data member
                mManufacturerName = value;
            }
        }

        //public property for Manufacturer ID
        public int ManufacturerId
        {
            get
            {
                //return the private data
                return mManufacturerId;
            }
            set
            {
                //set the value of the private data member
                mManufacturerId = value;

            }
        }

        public bool Find(int ManufacturerId)
        {
            //initialise the DB Connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Manufacturer ID to search for
            DB.AddParameter("ManufacturerId", ManufacturerId);
            //execute the store procedure
            DB.Execute("sproc_Manufacturer_FilterByManufacturerId");
            //if one record is found (there shouuld be either one or zero!)
            if (DB.Count == 1)
            {
                //COPY THE DATA FROM THE DATABASE TO THE PRIVATE DATA MEMBERS
                mManufacturerId = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturerId"]);
                mManufacturerName = Convert.ToString(DB.DataTable.Rows[0]["ManufacturerName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTelephone = Convert.ToInt32(DB.DataTable.Rows[0]["Telephone"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string ManufacturerName, string Address, string Telephone, string EmailAddress)
        {
            //create  a string variable to store the error
            String Error = "";
            //if the ManufacturerName is blank
            if (ManufacturerName.Length == 0)
            {
                //record the error
                Error = Error + "The ManufacturerName may not be blank:";

            }
            //if the ManufacturerName is greater than 15 characters
            if (ManufacturerName.Length > 15)
            {
                //record the error
                Error = Error + "The ManufacturerName must be less than 15 Characters: ";
            }



            //if the telephone is blank
            if (Telephone.Length == 0)
            {
                //record the error
                Error = Error + "The Telephone may not be blank:";

            }
            //if the Telephone is greater than 10 characters
            if (Telephone.Length > 10)
            {
                //record the error
                Error = Error + "The Telephone must be less than 10 Characters: ";
            }

            //if the email address is blank
            if (EmailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The EmailAddress may not be blank:";

            }
            //if the Telephone is greater than 50 characters
            if (EmailAddress.Length > 50)
            {
                //record the error
                Error = Error + "The EmailAddress must be less than 50 Characters: ";
            }
            //return any error messages
            return Error;
        }

         


    }

}
       
     

    
  



  
    

