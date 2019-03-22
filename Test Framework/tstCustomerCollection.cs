using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wan to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerNo = 29;
            TestItem.CustomerPostCode = "LE2 0AU";
            TestItem.CustomerName = "Jake";
            TestItem.CustomerAddress = "62 Charnwood Street";
            TestItem.PhoneNumber = 0792927638;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }



        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Active = true;
            TestCustomer.CustomerNo = 29;
            TestCustomer.CustomerPostCode = "LE2 0AU";
            TestCustomer.CustomerName = "Jake";
            TestCustomer.CustomerAddress = "62 Charnwood Street";
            TestCustomer.PhoneNumber = 0792927638;

            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerPostCode = "LE2 0AU";
            TestItem.CustomerName = "Jake";
            TestItem.CustomerAddress = "62 Charnwood Street";
            TestItem.PhoneNumber = 0792927638;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }




        [TestMethod]
        public void ReportByPostCodeMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerPostCode("LE2 0AU");

            //test to see that the result is correct
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }



        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn'exist
            FilteredCustomers.ReportByCustomerPostCode("LE2 0AU");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {

                //CHECK that the record is ID 29
                if (FilteredCustomers.CustomerList[0].CustomerNo != 29)
                {
                    OK = false;

                }
                if (FilteredCustomers.CustomerList[29].CustomerNo != 30)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //TEST TO SEE THAT THERE AER NO RECORDS
                Assert.IsTrue(OK);
            }
        }


       







        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerPostCode = "LE2 0AU";
            TestItem.CustomerName = "Jake";
            TestItem.CustomerAddress = "62 Charnwood Street";
            TestItem.PhoneNumber = 792927638;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerNo = PrimaryKey;

            TestItem.Active = false;
            TestItem.CustomerPostCode = "L72 0AY";
            TestItem.CustomerName = "Brina";
            TestItem.CustomerAddress = "7 Sherrard Street";
            TestItem.PhoneNumber = 792957638;
            AllCustomers.ThisCustomer = TestItem;
            
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerNo = 29;
            TestItem.CustomerPostCode = "LE2 0AU";
            TestItem.CustomerName = "Jake";
            TestItem.CustomerAddress = "62 Charnwood Street";
            TestItem.PhoneNumber = 0792927638;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNo = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerNo = 29;
            TestItem.CustomerPostCode = "LE2 0AU";
            TestItem.CustomerName = "Jake";
            TestItem.CustomerAddress = "62 Charnwood Street";
            TestItem.PhoneNumber = 0792927638;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNo = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }







    }

}

