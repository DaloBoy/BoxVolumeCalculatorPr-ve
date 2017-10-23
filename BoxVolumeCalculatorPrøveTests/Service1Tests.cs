using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoxVolumeCalculatorPrøve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxVolumeCalculatorPrøve.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDataUsingDataContractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSideTestSuccess()
        {
            //Arrange
            var box = new Service1();
            //Act
            var test = box.GetSide(40, 2, 5);
            //Assert
            Assert.AreEqual(4, test);
        }
       
        [TestMethod()]
        public void GetVolumeTestSuccess()
        {
            //Arrange
            var box = new Service1();
            //Act
            var test = box.GetVolume(4, 5, 2);
            //Assert
            Assert.AreEqual(40, test);
        }
    
    }
}