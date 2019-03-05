using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        int ComputerNo = 1;
        int CustomerNo = 1;
        string ItemName = "TestItemName";
        string CustomerName = "TestCustomerName";
        int Invoice = 1;
        string DeliveryDate = DateTime.Now.Date.ToString();
        string OrderDate = DateTime.Now.Date.ToString();
        string Status = "true";

        [TestMethod]
        public void InstanceOK()
        {
            //create n instnce of our class clsOrder
            clsOrder AnOrder = new clsOrder();
            //check to se that the class is not null
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }


        [TestMethod]
        public void ComputerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.ComputerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ComputerNo, TestData);
        }


        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerNo, TestData);
        }


        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DeliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }


        [TestMethod]
        public void InvoicePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            Int32 TestData = 635;
            //assign the data to the property
            AnOrder.Invoice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Invoice, TestData);
        }


        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            string TestData = "Asus650";
            //assign the data to the property
            AnOrder.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemName, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            string TestData = "Asus650";
            //assign the data to the property
            AnOrder.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }


        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create TestData test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Status, TestData);
        }



        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to test the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is OK i.e there was no error message returned
            Assert.IsTrue(Found);
        }

                                           
                                               //NoFound testing
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestComputerNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.ComputerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.ItemName != "TestItemName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.CustomerName != "TestCustomerName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInvoiceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.Invoice != 18)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.DeliveryDate !=Convert.ToDateTime("17/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.Status != true)
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
            clsOrder AnOrder = new clsOrder();
            //string to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(ComputerNo, CustomerNo, ItemName, CustomerName, Invoice, DeliveryDate, OrderDate, Status);
        }

    }
}
