using System;
using Class_Library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Class_Library
{
    public class clsOrderCollection
    {

        //constructor for the class
        public clsOrderCollection()
        {
            //object for dataconnection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);   
        }

        //private data member for the List
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for the List
        clsOrder mThisOrder = new clsOrder();


        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the value of the private data member
                mOrderList = value;
            }

        }

        public int Count
        {
            get
            {
                //return the private data
                return mOrderList.Count;
            }
            set
            {
                //we shall woryy about this later
            }

        }


        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the value of the private data member
                mThisOrder = value;
            }

        }


        public int Add()
        {
            //add a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the parameters
            DB.AddParameter("@ComputerNo", mThisOrder.ComputerNo);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@Invoice", mThisOrder.Invoice);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Status", mThisOrder.Status);
            //execute the stored procedure returning the primary key value of the new record
            return DB.Execute("sproc_tblOrder_Insert");
        }


        public void Delete()
        {
            //delete  the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }



        public void Update()
        {
            //update an existing record based on the values of This Order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the parameters
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@ComputerNo", mThisOrder.ComputerNo);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@Invoice", mThisOrder.Invoice);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Status", mThisOrder.Status);
            //execute the query
            DB.Execute("sproc_tblOrder_Update");
        }


        public void ReportByCustomerName(string CustomerName)
        {
            //filters the records based on a full or partial Customer Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerName prarameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerName");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.ComputerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ComputerNo"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnOrder.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.Invoice = Convert.ToInt32(DB.DataTable.Rows[Index]["Invoice"]);
                AnOrder.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                //add the blank page to the array list
                mOrderList.Add(AnOrder);
                //point to the next record
                Index++;
            }

        }
    }
}