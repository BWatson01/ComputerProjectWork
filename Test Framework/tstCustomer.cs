using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exist
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeCustomer = "Jake";
            //assign the data to the property
            AnCustomer.CustomerName = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerName, SomeCustomer);
        }


        [TestMethod]
        public void CustomerAddress()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeCustomerAddress = "62 Charnwood Street";
            //assign the data to the property
            AnCustomer.CustomerAddress = SomeCustomerAddress;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddress, SomeCustomerAddress);

        }


 [TestMethod]
        public void CustomerPostCode()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomePostCode = "LE2 0AU";
            //assign the data to the property
            AnCustomer.CustomerPostCode = SomePostCode;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPostCode, SomePostCode);
        }



        [TestMethod]
        public void CustomerNo()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 SomeCustomerNo = 5431;
            //assign the data to the property
            AnCustomer.CustomerNo = SomeCustomerNo;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, SomeCustomerNo);
        }


       
      

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 SomePhoneNumber = 0792927635;
            //assign the data to the property
            AnCustomer.PhoneNumber = SomePhoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, SomePhoneNumber);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "Jake";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

    }
}
