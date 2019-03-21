using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AnOrder = new clsOrderCollection();
            //check to se that the class is not null
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderListOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.ComputerNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.ItemName = "TestItemName";
            TestItem.CustomerName = "TestCustomerName";
            TestItem.Invoice = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Processing";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderNo = 1;
            TestOrder.ComputerNo = 1;
            TestOrder.CustomerNo = 1;
            TestOrder.ItemName = "TestItemName";
            TestOrder.CustomerName = "TestCustomerName";
            TestOrder.Invoice = 1;
            TestOrder.DeliveryDate = DateTime.Now.Date;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.Status = "Processing";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.ComputerNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.ItemName = "TestItemName";
            TestItem.CustomerName = "TestCustomerName";
            TestItem.Invoice = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Processing";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }



        [TestMethod]
        public void AddMethodOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.ComputerNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.ItemName = "TestItemName";
            TestItem.CustomerName = "TestCustomerName";
            TestItem.Invoice = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Processing";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.ComputerNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.ItemName = "TestItemName";
            TestItem.CustomerName = "TestCustomerName";
            TestItem.Invoice = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Processing";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create n instnce of our class clsOrder
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ComputerNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.ItemName = "TestItemName";
            TestItem.CustomerName = "TestCustomerName";
            TestItem.Invoice = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Processing";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            TestItem.ComputerNo = 2;
            TestItem.CustomerNo = 2;
            TestItem.ItemName = "Mudrik";
            TestItem.CustomerName = "Mohamed";
            TestItem.Invoice = 2;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Processing";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that ThisOrder matches the TestData
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void CustomerNameMethodOK()
        {
            //create an instnce of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByCustomerName("TestCustomerName");
            //test to see that the two values are the same
            Assert.AreNotEqual(6, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            //create an instnce of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a blank string (should return all records)
            FilteredOrders.ReportByCustomerName("TestCustomerName");
            //check that the correct number of records are found
            if(FilteredOrders.Count == 2)
            {
                //check tht the first record is ID 3
                if (FilteredOrders.OrderList[0].OrderNo != 3)
                {
                    OK = false;
                }
                //check to see that the first record is 37
                if (FilteredOrders.OrderList[1].OrderNo != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsFalse(OK);
        }

    }
}
