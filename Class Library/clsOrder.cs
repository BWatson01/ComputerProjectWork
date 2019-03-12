using System;

namespace Class_Library
{
    public class clsOrder
    {
        //private data member for the OrderNo property
        private Int32 mOrderNo;
        //private data member for the ComputerNo property
        private int mComputerNo; 
        //private data member for the CustomerNo property
        private int mCustomerNo;
        //private data member for the ItemName property
        private string mItemName;
        //private data member for the ItemName property
        private string mCustomerName;
        //private data member for the Invoice property
        private int mInvoice;
        //private data member for the DeliveryDate property
        private DateTime mDeliveryDate;
        //private data member for the OrderDate property
        private DateTime mOrderDate;
        //private data member for the Status property
        private bool mStatus; 

        public int OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }

        }

        public int ComputerNo
        {
            get
            {
                //return the private data
                return mComputerNo;
            }
            set
            {
                //set the value of the private data member
                mComputerNo = value;
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
                //set the value of the private data member
                mCustomerNo = value;
            }

        }

       

        public string ItemName
        {
            get
            {
                //return the private data
                return mItemName;
            }
            set
            {
                //set the value of the private data member
                mItemName = value;
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
                //set the value of the private data member
                mCustomerName = value;
            }

        }

        public int Invoice
        {
            get
            {
                //return the private data
                return mInvoice;
            }
            set
            {
                //set the value of the private data member
                mInvoice = value;
            }

        }

        public DateTime DeliveryDate
        {
            get
            {
                //return the private data
                return mDeliveryDate;
            }
            set
            {
                //set the value of the private data member
                mDeliveryDate = value;
            }

        }

        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }

        }

        public bool Status
        {
            get
            {
                //return the private data
                return mStatus;
            }
            set
            {
                //set the value of the private data member
                mStatus = value;
            }

        }

        public bool Find(int OrderNo)
        {
            //initialise the DB Connection
            clsDataConnection DB = new clsDataConnection();
            //add the order no parameter
            DB.AddParameter("OrderNo", OrderNo);
            //execute the query
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if the record was found
            if (DB.Count == 1)
            {
                //get the OrderNo
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                //get the ComputerNo
                mComputerNo = Convert.ToInt32(DB.DataTable.Rows[0]["ComputerNo"]);
                //get the CustomerNo
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                //get the ItemName
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                //get the CustomerName
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                //get the Invoice
                mInvoice = Convert.ToInt32(DB.DataTable.Rows[0]["Invoice"]);
                //get the DeliveryDate
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                //get the OrderDate
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                try
                {
                    //get the Status
                    mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                }
                catch
                {
                    mStatus = true;
                }
                //return success
                return true;
            }
            else
            {
                //return failure
                return false;
            }
        }



        public string Valid(string ComputerNo, string CustomerNo, string ItemName, string CustomerName, string Invoice, string DeliveryDate, string OrderDate, string Status)
        {
            //create a strng variable to store the error
            String Error = "";
            //check the min length of the ComputerNo
            if (ComputerNo.Length == 0)
            {
                //set the error messsage
                Error = Error + "ComputerNo is blank. ";
            }
            //check the max length of the ComputerNo
            if (ComputerNo.Length > 3)
            {
                //set the error messsage
                Error = Error + "ComputerNo must be less than 4 characters. ";
            }


            //check the min length of the CustomerNo
            if (CustomerNo.Length == 0)
            {
                //set the error messsage
                Error = Error + "CustomerNo is blank. ";
            }
            //check the max length of the CustomerNo
            if (CustomerNo.Length > 3)
            {
                //set the error messsage
                Error = Error + "CustomerNo must be less than 4 characters. ";
            }


            //check the min length of the ItemName
            if (ItemName.Length == 0)
            {
                //set the error messsage
                Error = Error + "ItemName is blank. ";
            }
            //check the max length of the ItemName
            if (ItemName.Length > 50)
            {
                //set the error messsage
                Error = Error + "ItemName must be less than 51 characters. ";
            }


            //check the min length of the CustomerName
            if (CustomerName.Length == 0)
            {
                //set the error messsage
                Error = Error + "CustomerName is blank. ";
            }
            //check the max length of the CustomerName
            if (CustomerName.Length > 50)
            {
                //set the error messsage
                Error = Error + "CustomerName must be less than 51 characters. ";
            }


            //check the min length of the Invoice
            if (Invoice.Length == 0)
            {
                //set the error messsage
                Error = Error + "Invoice is blank. ";
            }
            //check the max length of the Invoice
            if (Invoice.Length > 6)
            {
                //set the error messsage
                Error = Error + "Invoice must be less than 6 characters. ";
            }


            //test if the DeliveryDate is valid
            try//try the operation
            {
                //var to store the DeliveryDate
                DateTime DateTemp;
                //assign the date to the temporary var
                DateTemp = Convert.ToDateTime(DeliveryDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the past : ";
                }
            }
            catch//if it failed report an error
            {
                //set the error messsage
                Error = Error + "DeliveryDate is not valid. ";
            }


            //test if the OrderDate is valid
            try//try the operation
            {
                //var to store the OrderDate
                DateTime DateTemp;
                //assign the date to the temporary var
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch//if it failed report an error
            {
                //set the error messsage
                Error = Error + "OrderDate is not valid. ";
            }


            
        }


    }
}