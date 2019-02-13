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
            //create some test data to assign to the property
            Int32 SomeOrderNo = 1;
            //assign the data to the property
            AnOrder.OrderNo = SomeOrderNo;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, SomeOrderNo);
        }


        [TestMethod]
        public void ComputerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 SomeComputerNo = 1;
            //assign the data to the property
            AnOrder.ComputerNo = SomeComputerNo;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ComputerNo, SomeComputerNo);
        }


        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 SomeCustomerNo = 1;
            //assign the data to the property
            AnOrder.CustomerNo = SomeCustomerNo;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerNo, SomeCustomerNo);
        }


        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeItem = "Asus650";
            //assign the data to the property
            AnOrder.ItemName = SomeItem;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemName, SomeItem);
        }

        [TestMethod]
        public void InvoicePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 SomeInvoice = 635;
            //assign the data to the property
            AnOrder.Invoice = SomeInvoice;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Invoice, SomeInvoice);
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
