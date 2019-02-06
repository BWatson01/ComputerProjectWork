using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstComputerCatcs
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of ur class clsComputer
            clsComputerCat AnComputerCat = new clsComputerCat();
            //check to see that the class is not bull
            Assert.IsNotNull(AnComputerCat);
        }
    }
}
