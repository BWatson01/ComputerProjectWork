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
    }
}
