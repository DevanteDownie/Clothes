using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsClothesCollection
    {
        internal int Clothes;

        public List<clsClothes> ClothesDescription { get; internal set; }

        //private data member for the list
        List<clsClothes> mClothesList = new List<clsClothes>();
        //Private data member ClothesName
        clsClothes mClothesname = new clsClothes();

        //public property for the Clothes list
        public List<clsClothes> ClothesList
        {
            get
            {
                //return the private data
                return mClothesList;
            }
            set
            {
                //set the private data
                mClothesList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mClothesList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsClothes ClothesName
        {
            get
            {
                //return the private data
                return mClothesname;
            }
            set
            {
                //set the private data
                mClothesname = value;
            }
        }
        public int Add()


        {
            //adds a new record to the database based on the values of mClothesname
            //set the primary key value of the new record
            mClothesname.ProductNo = 123;
            //return the primary key of the new record
            return mClothesname.ProductNo;

            //adds a new record to the database based on the values of mClothesname
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parametres for the stored procedure
            DB.AddParameter("@ProductNo", mClothesname.ProductNo);
            DB.AddParameter("@ClothesCost", mClothesname.ClothesCost);
            DB.AddParameter("@ClothesName", mClothesname.ClothesName);
            DB.AddParameter("@ClothesDescription", mClothesname.ClothesDescription);
            DB.AddParameter("@Active", mClothesname.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblClothes_Insert");
        }


        //constructor for the class
        public clsClothesCollection()
        {
            ////create the items of test data
            //clsClothes TestItem = new clsClothes();
            ////set its properties
            //TestItem.Active = true;
            //TestItem.ClothesCost = 1;
            //TestItem.ClothesDescription = "Small White T Shirt";
            //TestItem.ClothesName = "White T Shirt";
            //TestItem.ProductNo = 1;
            ////add the item to the test list
            //mClothesList.Add(TestItem);
            ////re initialise the object for some new data
            //TestItem = new clsClothes();
            ////set its properties
            //TestItem.Active = true;
            //TestItem.ClothesCost = 2;
            //TestItem.ClothesDescription = "Small White T Shirt";
            //TestItem.ClothesName = "White T Shirt";
            //TestItem.ProductNo = 2;
            ////add the item to the test list
            //mClothesList.Add(TestItem);

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblClothes_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                clsClothes ClothingItem = new clsClothes();
                //read in the fields from the current record
                ClothingItem.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ClothingItem.ClothesCost = Convert.ToInt32(DB.DataTable.Rows[Index]["ClothesCost"]);
                ClothingItem.ClothesDescription = Convert.ToString(DB.DataTable.Rows[Index]["ClothesDescription"]);
                ClothingItem.ClothesName = Convert.ToString(DB.DataTable.Rows[Index]["ClothesName"]);
                ClothingItem.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                //Add the record to the private data member
                mClothesList.Add(ClothingItem);
                //point at the next record
                Index++;
            }
        }

        public void Delete()
        {
            //deletes the record pointed to by ClothesName
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductNo", mClothesname.ProductNo);
            //execute the stored procedure
            DB.Execute("sproc_tblClothes_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ClothesName
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameteres for the stored procedure
            DB.AddParameter("@ProuctNo", mClothesname.ProductNo);
            DB.AddParameter("@ClothesCost", mClothesname.ClothesCost);
            DB.AddParameter("@ClothesName", mClothesname.ClothesName);
            DB.AddParameter("@ClothesDescription", mClothesname.ClothesDescription);
            DB.AddParameter("@Active", mClothesname.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblClothes_Update");
        }

        public void FilterByClothesName(string ClothesName)
        {
            //filters the records based on a full or partial ClothesName
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ClothesName parameter to the database
            DB.AddParameter("@ClothesName", ClothesName);
            //execute the stored procedure
            DB.Execute("sproc_tblClothes_FilterByClothesName");
            //populate the array list with the data table
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mClothesList = new List<clsClothes>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsClothes Clothingitem = new clsClothes();
                //read in the fields from the current record
                Clothingitem.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                Clothingitem.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Clothingitem.ClothesCost = Convert.ToInt32(DB.DataTable.Rows[Index]["ClothesCost"]);
                Clothingitem.ClothesDescription = Convert.ToString(DB.DataTable.Rows[Index]["ClothesDescription"]);
                Clothingitem.ClothesName = Convert.ToString(DB.DataTable.Rows[Index]["ClothesName"]);
                //add the record to the private data member
                mClothesList.Add(Clothingitem);
                //point at the next record
                Index++;
            }
        }
    }
}


    
