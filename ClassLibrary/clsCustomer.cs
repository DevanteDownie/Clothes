using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the ShippingInfo property
        private String mShippingInfo;
        public string ShippingInfo
        {
            get
            {
                //return the private data 
                return mShippingInfo;
            }
            set
            {
                //set the value of the private data member
                mShippingInfo = value;
            }
        }
        //private data member for the CustomerName property
        private String mCustomerName;
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


        //private data member for the address property
        private Int32 mAddressNo;
        public int AddressNo
        {
            get
            {
                //return the private data 
                return mAddressNo;
            }
            set
            {
                //set the value of thge private data member
                mAddressNo = value;
            }
        }



        //private data member for the Email property
        private String mEMail;
        public string EMail
        {
            get
            {
                //return the private data 
                return mEMail;
            }
            set
            {
                //set the value of the private data member
                mEMail = value;
            }
        }
        //private data member for the Active property
        private Boolean mActive;
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data 
                mActive = value;
            }
        }

        public bool Find(int AddressNo)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for 
            DB.AddParameter("@AddressNo", AddressNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblAddress_FilterByAddressNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAddressNo = Convert.ToInt32(DB.DataTable.Rows[0]["AddressNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mEMail = Convert.ToString(DB.DataTable.Rows[0]["EMail"]);
                mShippingInfo = Convert.ToString(DB.DataTable.Rows[0]["ShippingInfo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK          
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string CustomerName, string EMail, string ShippingInfo)
        {

           
           //create a Boolean variable to flag the error
            Boolean OK = true;
            //if the CustomerName is blank
            if (CustomerName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the customer name is greater than 10 characters
            if (CustomerName.Length > 10)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the EMail blank
            if (EMail.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the EMail is too long
            if (EMail.Length > 50)
            {
                //set the flag to false
                OK = false;
            }

            //is the ShippingInfo blank
            if (ShippingInfo.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the ShippingInfo is too long
            if (ShippingInfo.Length > 50)
            {
                //set the flag to false
                OK = false;
            }

            //return the value of OK
            return OK;
        }
    }
}
        


       




