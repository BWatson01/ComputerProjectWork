using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstOrder
    {
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


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the results of the method
            String Error = "";
            //create some test data to test the method
            string SomeItem = "Asus650";
            //invoke the method
            Error = AnOrder.Valid(SomeItem);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }




    }
}
