using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string Address = "62 Charnwood Street";
        string CustomerNo = "29";
        string CustomerName = "Jake";
        string PhoneNumber = "0792927638";
        string PostCode = "LE2 0AU";


        public object TestCustomer { get; private set; }
        public object AllCustomers { get; private set; }
        public object AllCustomer { get; private set; }
        public object TestList { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wan to create
            clsCustomer AllCustomers = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
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
        public void CustomerAddressPropertyOK()
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
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE2 0AU";
            //assign the data to the property
            AnCustomer.CustomerPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPostCode, TestData);
        }





        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 29;
            //assign the data to the property
            AnCustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }





        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 0792927635;
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            String Error = "";
            //create some test data to test the method
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            Boolean Found = false;
            //create some test data to test the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //test to see that the result is OK i.e there was no error message returned
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }


   

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the address no
            if (AnCustomer.CustomerNo != 29)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }







        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            Boolean Found = false;
            //BOOLEAN VARIABLE TO RECORD IF DATA IS OK
            Boolean OK = true;
            //create some test data to test the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the address no
            if (AnCustomer.CustomerAddress != "62 Charnwood Street")
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
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            Boolean Found = false;
            //BOOLEAN VARIABLE TO RECORD IF DATA IS OK
            Boolean OK = true;
            //create some test data to test the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the address no
            if (AnCustomer.CustomerName != "Jake")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            Boolean Found = false;
            //BOOLEAN VARIABLE TO RECORD IF DATA IS OK
            Boolean OK = true;
            //create some test data to test the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the address no
            if (AnCustomer.PhoneNumber != 0792927638)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            Boolean Found = false;
            //BOOLEAN VARIABLE TO RECORD IF DATA IS OK
            Boolean OK = true;
            //create some test data to test the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the address no
            if (AnCustomer.CustomerPostCode != "LE2 0AU")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 29;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }













        // Testing for my 29st Property CustomerName
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            String Error = "";
            //create some test data to test the method
            string CustomerName = "Jake";
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        // Testing for my 29st Property CustomerName
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            String Error = "";
            //create some test data to test the method
            string Address = "62 Charnwood Street";
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        // Testing for my 29st Property CustomerName
        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the results of the method
            String Error = "";
            //create some test data to test the method
            string PhoneNumber = "0792927638";
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PostCode = "L"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        // Testing for my 29st Property CustomerName











        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "62 Charnwood Street"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Jake"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0792927638"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE2 0AU"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }















        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "62 Charnwood Street"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Jake"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0792927638"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE2 0AU"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "62 Charnwood Street"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Jake"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0792927638"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE2 0AU"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }















        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "62 Charnwood Street"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Jake"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0792927638"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE2 0AU"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }












        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "62 Charnwood Street"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Jake"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0792927638"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE2 0AU"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Address, CustomerName, PhoneNumber, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

 

    }
}


