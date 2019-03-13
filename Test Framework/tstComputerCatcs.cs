using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;


namespace Test_Framework
{
    [TestClass]
    public class tstComputerCat
    {

        //good test data
        //create some test data to pass the method
        string ComputerName = "macbook";
        string ComputerSize = "1011gb";
        string ComputerManufacturer = "Apple";


        //l
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of ur class clsComputer
            clsComputerCat AnComputerCat = new clsComputerCat();
            //test to see that it exists
            Assert.IsNotNull(AnComputerCat);
        }
        [TestMethod]
        public void ComputerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //create some test data to assign to the property
            int TestData = 211;
            //assign the data to the property
            AnComputerCat.ComputerID = TestData;
            //test to see that the two values 
            Assert.AreEqual(AnComputerCat.ComputerID, TestData);
        }

        [TestMethod]
        public void ComputerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //create some test data to assign to the property
            string TestData = "macbook";
            //assign the data to the property
            AnComputerCat.ComputerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnComputerCat.ComputerName, TestData);
        }

        [TestMethod]
        public void ComputermanufacturerOK()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //create some test data to assign to the property
            string Testdata = "Apple";
            //assign the data to the property
            AnComputerCat.ComputerManufacturer = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AnComputerCat.ComputerID, Testdata);
        }

        [TestMethod]
        public void ComputerSizeOK()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            AnComputerCat.ComputerSize = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnComputerCat.ComputerSize, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create

            clsComputerCat AnPc = new clsComputerCat();
            //boolean variable to store the result of validation
            Boolean Found = false;
            //create test data with the method
            Int32 ComputerID = 1;
            //invoke the method
            Found = AnPc.Find(ComputerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnComputerCat.Valid(ComputerName, ComputerManufacturer, ComputerSize);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestComputerNameFound()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //boolEAN VARIABLE TO STORE THE result of the search
            Boolean Found = false;
            //boolean variable to record if data is good
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ComputerID = 23;
            //invoke the method

            Found = AnComputerCat.Find(ComputerID);
            //check the computer Name
            if (AnComputerCat.ComputerName != "macbook")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestComputerManufacturerFound()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //boolEAN VARIABLE TO STORE THE result of the search
            Boolean Found = false;
            //boolean variable to record if data is good
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ComputerID = 23;
            //invoke the method

            Found = AnComputerCat.Find(ComputerID);
            //check the computer Name
            if (AnComputerCat.ComputerManufacturer != "Apple")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestComputerSizeFound()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //boolEAN VARIABLE TO STORE THE result of the search
            Boolean Found = false;
            //boolean variable to record if data is good
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ComputerID = 23;
            //invoke the method

            Found = AnComputerCat.Find(ComputerID);
            //check the computer Name
            if (AnComputerCat.ComputerSize != 1011)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestComputerIDFound()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerCat = new clsComputerCat();
            //boolEAN VARIABLE TO STORE THE result of the search
            Boolean Found = false;
            //boolean variable to record if data is good
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ComputerID = 211;
            //invoke the method

            Found = AnComputerCat.Find(ComputerID);
            //check the computer Name
            if (AnComputerCat.ComputerID != 322)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void ComputerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsComputerCat AnComputerID = new clsComputerCat();
            //STRING variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ComputerName = ""; //this should trigger an error
                                      //invoke the method
            Error = AnComputerID.Valid(ComputerName, ComputerManufacturer, ComputerSize);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }

}