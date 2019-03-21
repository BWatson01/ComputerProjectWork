using System;
using Class_Library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Class_Library

{
    public class clsManufacturerCollection
    {
          //constructor for the class
        public clsManufacturerCollection()
        {
            
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Manufacturer_SelectAll");
            //populate the arrary list with the data tble
            PopulateArray(DB);
             
        }


        List<clsManufacturer> mManufacturerList = new List<clsManufacturer>();
        clsManufacturer mThisManufacturer = new clsManufacturer();


        //public property for te manufacturer List
        public List<clsManufacturer> ManufacturerList
        {
            get
            {
                //return the private data
                return mManufacturerList;

            }
            set
            {
                //set the private data
                mManufacturerList = value;
            }
        }
        //PUBLIC PROPERTY FOR COUNT
        public int Count
        {
            get
            {
                //return the count of teh list
                return mManufacturerList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }
        //public property for ThisManufacturer
        public clsManufacturer ThisManufacturer
        {
            get
            {
                //return theprivate data
                return mThisManufacturer;

            }
            set
            {
                //set the privatye data
                mThisManufacturer = value;

            }
        }

        

      
     
        public int Add()
        {
            //adds a new record to the database based on the values of mThisManufacturer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
           
            DB.AddParameter("@ManufacturerName", mThisManufacturer.ManufacturerName);
            DB.AddParameter("@Address", mThisManufacturer.Address);
            DB.AddParameter("@Telephone", mThisManufacturer.Telephone);
            DB.AddParameter("@EmailAddress", mThisManufacturer.EmailAddress);
            //execute the query returning teh primary key value
            return DB.Execute("sproc_Manufacturer_Insert");
        }
        public void Delete()
        { 
            //deletes the record pointed to by thisManufacturer
            //connect to th edatabase
        clsDataConnection DB = new clsDataConnection();
        //set the parameters for the stored procedure
        DB.AddParameter("@ManufacturerId", mThisManufacturer.ManufacturerId);
        //execute the store procedure
        DB.Execute("sproc_Manufacturer_Delete");
            }
        public void Update()
        {
            //update an existing record based on th evalues of thisManufacturer
            //connect to the  database
            clsDataConnection DB = new clsDataConnection();
;
            //set the parameters for te stored procedure
            DB.AddParameter("@ManufacturerId", mThisManufacturer.ManufacturerId);
            DB.AddParameter("@ManufacturerName", mThisManufacturer.ManufacturerName);
            DB.AddParameter("@Address", mThisManufacturer.Address);
            DB.AddParameter("@Telephone", mThisManufacturer.Telephone);
            DB.AddParameter("@EmailAddress", mThisManufacturer.EmailAddress);
            //execute the stored procedure
            DB.Execute("sproc_Manufacturer_Update");
        }
       
        public void ReportByManufacturerName(string ManufacturerName)
        {
            //filters the ercords based on a full or partial post code
            //connect to teh databse
            clsDataConnection DB = new clsDataConnection();
            //send the ManufacturerName to the database
            DB.AddParameter("@ManufacturerName", ManufacturerName);
            //execute the stored procedure
            DB.Execute("sproc_Manufacturer_FilterByManufacturerName");
            //POPULATE THE arrray list with th data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //POPULATES THE ARRAY LIST BASED ON THE TABLE IN THE PARAMETER DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of reords
            RecordCount = DB.Count;
            //clear the private array list
            mManufacturerList = new List<clsManufacturer>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank MANUFACTURER
                clsManufacturer AnManufacturer = new clsManufacturer();
                //read in t fields from the current record
                AnManufacturer.ManufacturerId = Convert.ToInt32(DB.DataTable.Rows[Index]["ManufacturerId"]);
                AnManufacturer.ManufacturerName = Convert.ToString(DB.DataTable.Rows[Index]["ManufacturerName"]);
                AnManufacturer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnManufacturer.Telephone = Convert.ToInt32(DB.DataTable.Rows[Index]["Telephone"]);
                AnManufacturer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                //add the record to the private data member
                mManufacturerList.Add(AnManufacturer);
                //point at the next record
                Index++;
            }
        }


        }
    }
    
    

    
