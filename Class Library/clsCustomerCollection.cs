using System;
using System.Collections.Generic;
using Class_Library;
namespace Class_Library
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();



        //construtor of the class
        public clsCustomerCollection()
        {

           
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);

            }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //var to store the record count

            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.CustomerPostCode = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCode"]);
                AnCustomer.PhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
        }

       



        //private data memeber for the list
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }






        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }




        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }

        }



        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.Execute("sproc_tblCustomer_Delete");
        }


        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);

            DB.Execute("sproc_tblCustomer_Update");

        }

        public void ReportByCustomerPostCode(string CustomerPostCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerPostCode", CustomerPostCode);
            DB.Execute("sproc_tblCustomer_FilterByCustomerPostCode");
            PopulateArray(DB);

        }

       
       

    }
}






    

 
            

