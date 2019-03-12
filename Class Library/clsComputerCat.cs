using System;

namespace Class_Library
{
    public class clsComputerCat
    {
        //private data member for the ComputerName property
        private string mComputerName;
        //private data member for computerName
        private int mComputerID;
        //private int for mComputerID
        private int mComputerSize;
        //private data for ComputerSize
        private string mComputerManufacturer;
        //private data for ComputerManufacturer

       
        //public proeperty for the computer name
        public string ComputerName
        {
            get
            {
                //return the private data
                return mComputerName;

            }
            set
            {
                //set the value of the private data member
                mComputerName = value;
            }
        }
        public int ComputerID
        {
            get
            {
                //return the private data
                return mComputerID;

            }
            set
            {
                //set the value of the private data member
                mComputerID = value;
            }
        }
        public int ComputerSize
        {
            get
            {
                //return the private data
                return mComputerSize;

            }
            set
            {
                //set the value of the private data member
                mComputerSize = value;
            }


        }
        public string ComputerManufacturer
        {
            get
            {
                //return the private data
                return mComputerManufacturer;

            }
            set
            {
                //set the value of the private data member
                mComputerManufacturer = value;
            }

        }




        public bool Find(int ComputerID)
        {
            //create an instance of the data connection
            clsDataCollection DB = new clsDataCollection();
            //add the parameter for the address no to search for 
            DB.addParameter("@ComputerNo", ComputerID);
            //execute the stored procedure
            DB.Execute("sproc_tblComputer_FilterByComputerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members

            }
            mComputerID = Convert.ToInt32(DB.dataTable.Rows[0]["ComputerID"]);
            mComputerName = Convert.ToString(DB.dataTable.Rows[0]["ComputerName"]);
            mComputerID = Convert.ToString(DB.dataTable.Rows[0]["ComputerManufacturer"]);
            mComputerSize = Convert.ToInt32(DB.dataTable.Rows[0]["ComputerSize"]);
            //return always true
            return true;
        }
        //if no record was found
        else
        {
        //return false indicating a problem
        return false;
        }

           
           
        }
    }
}