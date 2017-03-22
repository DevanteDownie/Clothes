using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class UnitTest1
    {
        public bool Found { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //test to see that it exists
            Assert.IsNotNull(ClothingItem);
        }
        [TestMethod]
        public void ClothesCost()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //Create some test data to assign to the property
            Int32 TestData = 20;
            //assign the data to the property
            ClothingItem.ClothesCost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ClothingItem.ClothesCost, TestData);
        }
        [TestMethod]
        public void ClothesDescription()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //Create some test data to assign to the property
            string TestData = "Small White T Shirt";
            //assign the data to the property
            ClothingItem.ClothesDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ClothingItem.ClothesDescription, TestData);
        }
        [TestMethod]
        public void ClothesName()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //Create some test data to assign to the property
            string TestData = "White T Shirt";
            //assign the data to the property
            ClothingItem.ClothesName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ClothingItem.ClothesName, TestData);
        }
        [TestMethod]
        public void ProductNo()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ClothingItem.ProductNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ClothingItem.ProductNo, TestData);
        }
        [TestMethod]
        public void FindMethod()
        {

            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            ClothingItem.Find(2);
            string ClothesName = ClothingItem.ClothesName;
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = ClothingItem.Find(ProductNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = ClothingItem.Find(ProductNo);
            //check the Product no
            if (ClothingItem.ProductNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestClothesNameFound()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;    // "White T Shirt";
            //invoke the method
            Found = ClothingItem.Find(ProductNo);
            //check the Clothes Name
            if (ClothingItem.ClothesName != "White T Shirt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestClothesCostFound()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = ClothingItem.Find(ProductNo);
            //check the Clothes Cost
            if (ClothingItem.ClothesCost != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestClothesDescriptionFound()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;// "Small White T Shirt";
            //invoke the method
            Found = ClothingItem.Find(ProductNo);
            //check the Clothes Cost
            if (ClothingItem.ClothesDescription != "Small White T Shirt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesCost = "1";
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMin()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMax()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMid()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "aaaaaaa";// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "";
            ClothesDescription = ClothesDescription.PadRight(500, 'a');// This should tigger an error
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ClotheCostMinLessOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ClothesCostMin()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesCostMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesCostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesCostMax()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesCostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "2`212111111111111111111122222222222222";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierMid()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ClothesNameMin()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "";
            ClothesName = ClothesName.PadRight(49, 'a');
            string ClothesCost = "1";
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesNameMax()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "";
            string ClothesCost = "1";
            ClothesName = ClothesName.PadRight(50, 'a');
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClothesNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "";
            ClothesName = ClothesName.PadRight(51, 'a');
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ClothesNameMid()
        {
            //create an instance of the class we want to create
            clsClothes ClothingItem = new clsClothes();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string ClothesDescription = "Small White T Shirt";
            string ClothesName = "White T Shirt";
            string ClothesCost = "1";
            ClothesName = ClothesName.PadRight(25, 'a');
            //invoke the method
            OK = ClothingItem.Valid(ClothesDescription, ClothesName, ClothesCost);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
