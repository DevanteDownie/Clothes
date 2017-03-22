using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data 
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //private data member for the list
        //List<clsCustomer> mCount = new List<clsCustomer>();
        public Int32 Count
        {
            get
            {
                //return the private data 
                return mCustomerList.Count;
            }
            set
            {
                //set the private data
                //mCount = value;
            }
        }

        //private data member for the list
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data 
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblAddress_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set teh parameters for the store procedure 
            //DB.AddParameter("@AddressNo", mThisCustomer.AddressNo);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@EMail", mThisCustomer.EMail);
            DB.AddParameter("@ShippingInfo", mThisCustomer.ShippingInfo);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAddress_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@AddressNo", mThisCustomer.AddressNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Delete");
        }

        public void Update()
        {
            //update ab existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@AddressNo", mThisCustomer.AddressNo);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@EMail", mThisCustomer.EMail);
            DB.AddParameter("@ShippingInfo", mThisCustomer.ShippingInfo);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Update");

        }

        public void FilterByEMail(string EMail)
        {
            //filters the records based on a full or partial email address
            //connect ot the database
            clsDataConnection DB = new clsDataConnection();
            //send the EMail paramater to the database
            DB.AddParameter("@EMail", EMail);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByEMail");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in that parameter DB
            mCustomerList = new List<clsCustomer>();
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.AddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressNo"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                ACustomer.ShippingInfo = Convert.ToString(DB.DataTable.Rows[Index]["ShippingInfo"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}