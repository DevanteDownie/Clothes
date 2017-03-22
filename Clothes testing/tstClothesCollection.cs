using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


namespace ClassLibrary
{
    [TestClass]
    public class tstClothesCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //test to see that it exists
            Assert.IsNotNull(AllClothes);
        }

        [TestMethod]
        public void ClothesList()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //Create some test data to assign to the property
            //in this ace the data needs to be a list of objects
            List<clsClothes> TestList = new List<clsClothes>();
            //add an item to the list
            //create an item of test data
            clsClothes TestItem = new clsClothes();
            //set its properties
            TestItem.Active = true;
            TestItem.ClothesCost = 1;
            TestItem.ClothesDescription = "Small White T Shirt";
            TestItem.ClothesName = "White T Shirt";
            TestItem.ProductNo = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClothes.ClothesList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllClothes.ClothesList, TestList);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //Create some test data to assign to the property
            //in this ace the data needs to be a list of objects
            List<clsClothes> TestList = new List<clsClothes>();
            //add an item to the list
            //create an item of test data
            clsClothes TestItem = new clsClothes();
            //set its properties
            TestItem.Active = true;
            TestItem.ClothesCost = 1;
            TestItem.ClothesDescription = "Small White T Shirt";
            TestItem.ClothesName = "White T Shirt";
            TestItem.ProductNo = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClothes.ClothesList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllClothes.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //create the item of test data
            clsClothes TestItem = new clsClothes();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.Active = true;
            TestItem.ClothesCost = 1;
            TestItem.ClothesDescription = "Small White T Shirt";
            TestItem.ClothesName = "White T Shirt";
            TestItem.ProductNo = 1;
            //set Clothing Item to the test data
            AllClothes.ClothesName = TestItem;
            //add the record
            PrimaryKey = AllClothes.Add();
            //set the primary key of the test data
            TestItem.ProductNo = PrimaryKey;
            //find the record
            AllClothes.ClothesName.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllClothes.ClothesName, TestItem);


        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //create the item of test data
            clsClothes TestItem = new clsClothes();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.Active = true;
            TestItem.ClothesCost = 1;
            TestItem.ClothesDescription = "Small White T Shirt";
            TestItem.ClothesName = "White T Shirt";
            TestItem.ProductNo = 1;
            //set Clothing Item to the test data
            AllClothes.ClothesName = TestItem;
            //add the record
            PrimaryKey = AllClothes.Add();
            //set the primary key of the test data
            TestItem.ProductNo = PrimaryKey;
            //find the record
            AllClothes.ClothesName.Find(PrimaryKey);
            //delete the record
            AllClothes.Delete();
            //now find the record
            Boolean Found = AllClothes.ClothesName.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        //[TestMethod]
        //public void UpdateMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsClothesCollection AllClothes = new clsClothesCollection();
        //    //create the item of test data
        //    clsClothes TestItem = new clsClothes();
        //    //var to store the primary key
        //    Int32 PrimaryKey = 0;
        //    //set it's properties
        //    TestItem.Active = true;
        //    TestItem.ClothesCost = 1;
        //    TestItem.ClothesDescription = "Small White T Shirt";
        //    TestItem.ClothesName = "White T Shirt";
        //    TestItem.ProductNo = 1;
        //    //set Clothing Item to the test data
        //    AllClothes.ClothesName = TestItem;
        //    //add the record
        //    PrimaryKey = AllClothes.Add();
        //    //set the primary key of the test data
        //    TestItem.ProductNo = PrimaryKey;
        //    //modify the test data
        //    TestItem.Active = false;
        //    TestItem.ClothesCost = 3;
        //    TestItem.ClothesDescription = "Large White T Shirt";
        //    TestItem.ClothesName = "Black T Shirt";
        //    TestItem.ProductNo = 3;
        //    //set the record based on the test data
        //    AllClothes.ClothesName = TestItem;
        //    //update the record
        //    AllClothes.Update();
        //    //find the record
        //    AllClothes.ClothesName.Find(PrimaryKey);
        //    //test to see ClothesName matches the test data
        //    Assert.AreEqual(AllClothes.ClothesName, TestItem);

        //}
        [TestMethod]
        public void FilterByClothesNameOK()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //Create an instance of the filtered data
            clsClothesCollection FilteredClothes = new clsClothesCollection();
            //apply a blank string (should return all records);
            FilteredClothes.FilterByClothesName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllClothes.Count, FilteredClothes.Count);
        }
        [TestMethod]
        public void FilterByClothesNameNoneFoundOK()
        {
            //create an instance of the class we want to create
            clsClothesCollection AllClothes = new clsClothesCollection();
            //apply a post code that doesn't exist
            clsClothesCollection FilteredClothes = new clsClothesCollection();
            FilteredClothes.FilterByClothesName("");
            //test to see that there are no records
            Assert.AreEqual(AllClothes.Count, FilteredClothes.Count);
        }
    }
}
    

