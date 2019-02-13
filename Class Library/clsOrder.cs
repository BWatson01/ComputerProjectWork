using System;

namespace Class_Library
{
    public class clsOrder
    {
        public int OrderNo { get; set; }
        public int ComputerNo { get; set; }
        public int CustomerNo { get; set; }
        public string ItemName { get; set; }
        public int Invoice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }

        public string Valid(string someOrder)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the county is not blank
            if (someOrder.Length > 50)
            {
                //return an error message
                Error = "The characters cannot be more than 50 characters";
            }
            if (someOrder.Length == 0)
            {
                //return an error message
                Error = "The section may not be blank!";
            }
            return Error;
        }

        public bool Find(int OrderNo)
        {
            //always return true
            return true;
        }
    }
}