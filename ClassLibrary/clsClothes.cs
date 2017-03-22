using System;

namespace ClassLibrary
{
    public class clsClothes
    {
        //private data member for the ProductNo property
        private Int32 mProductNo;
        //private data member for the ClothesCost property
        private Int32 mClothesCost;
        //private data member for the ClothesDescription property
        private string mClothesDescription;
        //private data member for the ClothesName property
        private string mClothesName;
        //public ClsClothes()
        //{

        //}
        //Public property for the product number
        public Int32 ClothesCost
        {

            get
            {
                //return the private data
                return mClothesCost;
            }
            set
            {
                //set the private data
                mClothesCost = value;

            }
        }
        //Public property for the Clothes Description
        public string ClothesDescription
        {
            get
            {
                //return the private data
                return mClothesDescription;
            }
            set
            {
                //set the private data
                mClothesDescription = value;
            }
        }
        //Public property for the Clothes Name
        public string ClothesName
        {
            get
            {
                //return the private data
                return mClothesName;
            }
            set
            {
                //set the private data
                mClothesName = value;
            }
        }

        //Public property for the Product number
        public int ProductNo

        {
            get
            {
                //return the private data 
                return mProductNo;
            }
            set
            {
                //set the value of the private data member
                mProductNo = value;
            }

        }

        public bool Active { get; set; }

        public bool Find(int productNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Product No to search for
            DB.AddParameter("@ProductNo", productNo);
            //execute the stored procedure
            DB.Execute("Sproc_tblClothes_FilterByProductNo");
            // If one record is found (There should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mClothesName = Convert.ToString(DB.DataTable.Rows[0]["ClothesName"]);
                mClothesDescription = Convert.ToString(DB.DataTable.Rows[0]["ClothesDescription"]);
                mClothesCost = Convert.ToInt32(DB.DataTable.Rows[0]["ClothesCost"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicationg a problem
                return false;
            }
        }

        public bool Valid(string clothesDescription, string clothesName, string clothesCost)
        {
            //Create a Boolean variable tp flag the error
            Boolean OK = true;
            //if the Clothes Description is blank
            if (clothesDescription.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Clothes Description is greater than 50 characters
            if (clothesDescription.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the ClothesName blank
            if (clothesName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the post code is too long
            if (clothesName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the ClothesName blank
            if (clothesCost.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the post code is too long
            if (clothesCost.Length > 9)
            {
                //set the flag OK to false
                OK = false;
            }
                //return the value of OK
                return OK;

        }

        //public static implicit operator int(ClsClothes v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}


            