using System;

namespace Class_Library
{
    public class clsCustomer
    {
        //private data member for the CustomerNo property
        private Int32 mCustomerNo;
        //private data member for CustomerAddress
        private string mCustomerAddress;
        //private data member for CustomerName
        private string mCustomerName;
        //private data member for PhoneNumber
        private Int32 mPhoneNumber;
        //private data member for post code
        private string mCustomerPostCode;
        //private data member for active
        private Boolean mActive;

        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }


        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }

            set
            {
                //set the value of the private data memeber
                mCustomerName = value;

            }

        }

        public int PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the value of the private data member
                mPhoneNumber = value;
            }
        }


        public string CustomerAddress
        {
            get
            {
                //return the private data
                return mCustomerAddress;
            }

            set
            {
                //set the value of the private data memeber
                mCustomerAddress = value;

            }

        }



        public int CustomerNo

        {
            get
            {
                //return the private data
                return mCustomerNo;
            }

            set
            {
                //set the value of the private data memeber
                mCustomerNo = value;

            }

        }


        public string CustomerPostCode
        {
            get
            {
                //return the private data
                return mCustomerPostCode;
            }
            set
            {
                //set the private data
                mCustomerPostCode = value;
            }
        }

      


        public bool Find(int CustomerNo)     
        {
            //set the private data members to the test data value
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                mCustomerPostCode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostCode"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;

            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string CustomerAddress, string CustomerName, string PhoneNumber, string CustomerPostCode)
        {
           //create a string variable to store the error
            String Error = "";


            if (CustomerPostCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (CustomerPostCode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }



            //if the Address is blank
            if (CustomerAddress.Length == 0)
            {
                Error = Error + "The last name may not be blank";
            }
            if (CustomerAddress.Length > 50)
            {
                Error = Error + " The last name must be less than 50 characters :   ";
            }


            //if the Customer Name is blank

            if (CustomerName.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (CustomerName.Length > 50)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }


            //if the Customer Phone Numberis blank

            if (PhoneNumber.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (PhoneNumber.Length > 11)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }


            //retur the error
            return Error;

        }

       

    }

}
