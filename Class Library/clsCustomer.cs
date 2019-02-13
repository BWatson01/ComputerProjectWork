using System;

namespace Class_Library
{
    public class clsCustomer
    {//comment
        public string CustomerName { get; set; }
        public int PhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerPostCode { get; set; }

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
    }
}