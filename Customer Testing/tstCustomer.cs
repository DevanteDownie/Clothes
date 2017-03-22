using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void AddressNoProperty()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the propety
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.AddressNo, TestData);

        }
        [TestMethod]
        public void CustomerNameProperty()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the propety
            String TestData = "Brian";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);

        }
        [TestMethod]
        public void EMailProperty()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the propety
            String TestData = "Brian@dafranklin.com";
            //assign the data to the property
            ACustomer.EMail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EMail, TestData);

        }
        [TestMethod]
        public void ShippingInfoProperty()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the propety
            String TestData = "Arrive on date specified";
            //assign the data to the property
            ACustomer.ShippingInfo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ShippingInfo, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(AddressNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNameFound()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(AddressNo);
            //check the customer no
            if (ACustomer.CustomerName != "Brian")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEMailFound()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(AddressNo);
            //check the property
            if (ACustomer.EMail != "Brian@dafranklin.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingInfoFound()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(AddressNo);
            //check the property
            if (ACustomer.ShippingInfo != "Arrive on date specified")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(AddressNo);
            //check the property
            if (ACustomer.AddressNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(AddressNo);
            //check the property
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = ""; //this should trigger an error
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerNameNoMin()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "a"; //this should be ok
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "aa"; //this should be ok
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "aaaaa"; //this should be ok
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameNoMax()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "aaaaaa"; //this should be ok
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameNoMid()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "aaa"; //this should be ok
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "aaaaaaaaaaa"; //this should fail
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EMailMinLessOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian"; 
            string EMail = ""; //this should trigger an error
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EMailMin()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian"; 
            string EMail = "a"; //this should be ok
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EMailMinPlusOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian"; 
            string EMail = "aa"; //this should be ok
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EMailMaxLessOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian"; 
            string EMail = "";
            EMail = EMail.PadRight(49, 'a');
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EMailMax()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "";
            EMail = EMail.PadRight(50, 'a');
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EMailMaxPlusOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "";
            EMail = EMail.PadRight(51, 'a');
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EMailMid()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "";
            EMail = EMail.PadRight(25, 'a');
            string ShippingInfo = "Arrive on date specified";
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingInfoMinLessOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = ""; //this should trigger an error
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ShippingInfoMin()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "a"; //this should be ok
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingInfoPlusOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "aa"; //this should be ok
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingInfoMaxLessOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "";
            ShippingInfo = ShippingInfo.PadRight(49, 'a');
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingInfoMax()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "";
            ShippingInfo = ShippingInfo.PadRight(50, 'a');
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingInfoMaxPlusOne()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "";
            ShippingInfo = ShippingInfo.PadRight(51, 'a');
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ShippingInfoMid()
        {//create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerName = "Brian";
            string EMail = "Brian@dafranklin.com";
            string ShippingInfo = "";
            ShippingInfo = ShippingInfo.PadRight(25, 'a');
            //invoke the method
            OK = ACustomer.Valid(CustomerName, EMail, ShippingInfo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
   



