using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Test_Framework
{
    [TestClass]
    public class tstManufacturerCollection
    {
        public object AllManufacturers { get; private set; }

        [TestMethod]
        public void InstanceOk()
        {
            //CREATE AN INSTANCE of the class we want to create
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllManufacturers);
        }


        [TestMethod]
        public void ManufacturerListOk()
        {
            //creat an instance of the class we want to create
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            ///create some test data to assign to the property
            //in thhis case the data needs to be a list of objects
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //add an item to the list
            //create the item of test data
            clsManufacturer TestItem = new clsManufacturer();
            //set its properties
            TestItem.ManufacturerId = 1;
            TestItem.ManufacturerName = " some name";
            TestItem.Address = " some address";
            TestItem.Telephone = 0770787810;
            TestItem.EmailAddress = "@gmail.com";
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllManufacturers.ManufacturerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllManufacturers.ManufacturerList, TestList);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create some test data to assign to the propety
            //in this case the data needs to be a list of objects
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //add an item to the list
            //create the item of test data
            clsManufacturer TestItem = new clsManufacturer();
            //set its properties
            TestItem.ManufacturerId = 1;
            TestItem.ManufacturerName = "Samsung";
            TestItem.Address = "3,London Road, Leicester";
            TestItem.Telephone = 0770787810;
            TestItem.EmailAddress = "samsung@gmail.com";
            TestList.Add(TestItem);
            //assig n the data to the property
            AllManufacturers.ManufacturerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllManufacturers.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisManufacturerPropertyOk()
        {
            //createan instance of the class we want to create
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create some test data to assign to the property
            clsManufacturer TestManufacturer = new clsManufacturer();
            //set the properties of the test object
            TestManufacturer.ManufacturerId = 1;
            TestManufacturer.ManufacturerName = "Samsung";
            TestManufacturer.Address = "3,London Road, Leicester";
            TestManufacturer.Telephone = 0770787810;
            TestManufacturer.EmailAddress = "samsung@gmail.com";
            //assign the data to the property
            AllManufacturers.ThisManufacturer = TestManufacturer;
            //test to see that the two values are the same
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestManufacturer);


        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create the item of test data
            clsManufacturer TestItem = new clsManufacturer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ManufacturerId = 20;
            TestItem.ManufacturerName = "Samsung";
            TestItem.Address = "3 London Road Leicester";
            TestItem.Telephone = 0770787810;
            TestItem.EmailAddress = "samsung@gmail.com";
            //set ThisManufacturer to the test data
            AllManufacturers.ThisManufacturer = TestItem;
            //add the record
            PrimaryKey = AllManufacturers.Add();
            //set the primary key of the test data
            TestItem.ManufacturerId = PrimaryKey;
            //Find the record
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an onstance of the class we want to create



         clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create the item of test data
            clsManufacturer TestItem = new clsManufacturer();
            //var to store teh primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ManufacturerId = 21;
            TestItem.ManufacturerName = "Samsung";
            TestItem.Address = "3,London Road, Leicester";
            TestItem.Telephone = 0770787810;
            TestItem.EmailAddress = "samsung@gmail.com";
            //set ThisManufacturerName to th etest data
            AllManufacturers.ThisManufacturer = TestItem;
            //addthe record
            PrimaryKey = AllManufacturers.Add();
            //set the primary key of the test data
            TestItem.ManufacturerId = PrimaryKey;
            //find the record
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //delete the record
            AllManufacturers.Delete();
            //now find the ercord
            Boolean Found = AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //test to see that the recoird was not found
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of teh class we want to create
            clsManufacturerCollection AllManufacturer = new clsManufacturerCollection();
            //create the item of test data
            clsManufacturer TestItem = new clsManufacturer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ManufacturerName = "Samsung";
            TestItem.Address = "3,London Road, Leicester";
            TestItem.Telephone = 0770787810;
            TestItem.EmailAddress = "samsung@gmail.com";
            //set ThisManufacturer to teh test data
            AllManufacturer.ThisManufacturer = TestItem;
            //add the record
            PrimaryKey = AllManufacturer.Add();
            //set the primary key of the test data
            TestItem.ManufacturerId = PrimaryKey;
            //modify the test data
            TestItem.ManufacturerName = "dell";
            TestItem.Address = "100,London Road, Leicester";
            TestItem.Telephone = 116435270;
            TestItem.EmailAddress = "dell@hotmail.com";
            //set the record based on the new test data
            AllManufacturer.ThisManufacturer = TestItem;
            //update the record
            AllManufacturer.Update();
            //find the record
            AllManufacturer.ThisManufacturer.Find(PrimaryKey);
            //test to see ThisManufacturer matches the test data
            Assert.AreEqual(AllManufacturer.ThisManufacturer, TestItem);

        }

        [TestMethod]
        public void ReportByManufacturerNameMethodOk()
        {
            //create an instance of the class containing unfilteres results
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create an instance of the filtered data
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            //APPLY A blank string (should return all records);
            FilteredManufacturers.ReportByManufacturerName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllManufacturers.Count, FilteredManufacturers.Count);
        }
        [TestMethod]
        public void ReportByManufacturerNameNoneFound()
        {
            //create an instance of the filtered data
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            //apply a ManufacturerName that doesnt exist
            FilteredManufacturers.ReportByManufacturerName("xxx xxx")
;
            //test to see that theer are no records
            Assert.AreEqual(0, FilteredManufacturers.Count);
        }
        [TestMethod]
        public void ReportByManufacturerNameTestDataFound()
        {
            //create an intance of the filtered data
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            //var to store  outcome
            Boolean Ok = true;
            //APPLY a mANUFCATURERnAME that doesnt exist
            FilteredManufacturers.ReportByManufacturerName("yyy yyy");
            //check that the correct number ofrecords are found
            if (FilteredManufacturers.Count ==2)
            {
                //check that th efirst record is Id36
                if (FilteredManufacturers.ManufacturerList[0].ManufacturerId != 36)
                {
                    Ok = false;
                
                }
                //check that the first  record isId 37
                if (FilteredManufacturers.ManufacturerList[1].ManufacturerId != 37)
                {
                    Ok = false;

                }

            }
            else
            {
                Ok = false;
            }
            //test to see that there are no records
            Assert.IsFalse(Ok);

        }
    }

  }

