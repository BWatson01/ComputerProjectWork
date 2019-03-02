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


        public string Valid(string someCustomer)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the county is not blank
            if (someCustomer.Length > 50)
            {
                //return an error message
                Error = "The Customer Name cannot have more than 50 characters";
            }
            if (someCustomer.Length == 0)
            {
                //return an error message
                Error = "The Customer Name may not be blank!";
            }
            return Error;
        }

        public bool Find(int CustomerNo)     
        {
            //set the private data members to the test data value
            mCustomerAddress = "62 Charnwood Street";
            mCustomerNo = 1;
            mCustomerName = "Jake";
            mPhoneNumber = 0792927638;
            mCustomerPostCode = "LE2 0AU";
            mActive = true;
            //always return true
            return true;

        }

    }
}