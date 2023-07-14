using GenericsPracticeProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberTest
{
    public class MaxNumberTest
    {

        [Test]
        public void TestMethod1()
        {

           Maximum maximum = new Maximum();
            //Arrange
            int firstValue = 100;
            int secondValue = 20;
            int thirdValue = 98;

            //Act
            int value = maximum.Number(firstValue,secondValue,thirdValue);
            //Assert
            Assert.AreEqual(firstValue,value);
        }

        [Test] 
        public void TestMethod2()
        {
            Maximum maximum = new Maximum();
            //Arrange
            int firstValue = 20;
            int secondValue = 100;
            int thirdValue = 98;

            //Act
            int value = maximum.Number(firstValue,secondValue,thirdValue);
            //Assert
            Assert.AreEqual(secondValue, value);
        }
    }
}

