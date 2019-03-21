using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Test_Framework
{
    [TestClass]
    public class tstManufacturer

    {
        //good test data
        //create some test tdata to pass to the method
        string ManufacturerName = "Name";
        string Address = "Address";
        string Telephone = "0770787810";
        string EmailAddress = " @gmail";
        public int ManufacturerID { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //check to see if this class exists by creating an instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //tell the system to check to see that a class with that name exists
            Assert.IsNotNull(AnManufacturer);
        }



        [TestMethod]
        public void ManufacturerNamePropertyOK()
        {
            //create an instance of the order class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnManufacturer.ManufacturerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.ManufacturerName, TestData);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the order class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnManufacturer.Telephone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.Telephone, TestData);
        }

        [TestMethod]
        public void ManufacturerIDPropertyOK()
        {
            //create an instance of the order class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnManufacturer.ManufacturerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.ManufacturerId, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the order class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnManufacturer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.Address, TestData);
        }
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the order class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnManufacturer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.EmailAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ManufacturerId = 1;
            //invoke the method
            Found = AnManufacturer.Find(ManufacturerId);
            //test to see taht the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestManufacturerIdFound()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of teh search
            Boolean Found = false;
            //boolean variable to recors if data is ok(assume as it is)
            Boolean OK = true;
            //CREATE some test data to use with the method
            Int32 ManufacturerId = 21;
            //invoke the method
            Found = AnManufacturer.Find(ManufacturerId);
            //check the manufacturer no
            if (AnManufacturer.ManufacturerId != 21)
            {
                OK = false;
            }

            //test to se that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestManufacturerNameFound()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of teh search
            Boolean Found = false;
            //boolean variable to recors if data is ok(assume as it is)
            Boolean OK = true;
            //CREATE some test data to use with the method
            Int32 ManufacturerId = 21;
            //invoke the method
            Found = AnManufacturer.Find(ManufacturerId);
            //check the manufacturer no
            if (AnManufacturer.ManufacturerName != "Samsung")
            {
                OK = false;
            }

            //test to se that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of teh search
            Boolean Found = false;
            //boolean variable to recors if data is ok(assume as it is)
            Boolean OK = true;
            //CREATE some test data to use with the method
            Int32 ManufacturerId = 21;
            //invoke the method
            Found = AnManufacturer.Find(ManufacturerId);
            //check the manufacturer no
            if (AnManufacturer.Address != "3,London road,Leicester")
            {
                OK = false;
            }

            //test to se that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTelephoneFound()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of teh search
            Boolean Found = false;
            //boolean variable to recors if data is ok(assume as it is)
            Boolean OK = true;
            //CREATE some test data to use with the method
            Int32 ManufacturerId = 21;
            //invoke the method
            Found = AnManufacturer.Find(ManufacturerId);
            //check the manufacturer no
            if (AnManufacturer.Telephone != 235556617)
            {
                OK = false;
            }

            //test to se that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of teh search
            Boolean Found = false;
            //boolean variable to recors if data is ok(assume as it is)
            Boolean OK = true;
            //CREATE some test data to use with the method
            Int32 ManufacturerId = 21;
            //invoke the method
            Found = AnManufacturer.Find(ManufacturerId);
            //check the manufacturer no
            if (AnManufacturer.EmailAddress != "samsung@gmail.com")
            {
                OK = false;
            }

            //test to se that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want  to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //TEST TO SEE that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ManufacturerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = ""; //this should trigger an error
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerNameMin()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "a";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMinPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "aa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMaxLessOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "aaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "aaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMid()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "aaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMaxPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "aaaaaaaaaaaaaaaa";//this should be an error
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameExtremeMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string ManufacturerName = "";
            ManufacturerName = ManufacturerName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
             [TestMethod]

        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should trigger an error
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "a";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void TelephoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "770787810"; //this should trigger an error
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMin()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "7";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneMinPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "77";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneMaxLessOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "770787810";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "7707878100";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneMid()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "77078";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneMaxPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "07707878100";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneExtremeMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "";
            Telephone = Telephone.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "a";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the classs we want to create
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store teh result of the validation
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
          EmailAddress = EmailAddress.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnManufacturer.Valid(ManufacturerName, Address, Telephone, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
       

    }
  }


