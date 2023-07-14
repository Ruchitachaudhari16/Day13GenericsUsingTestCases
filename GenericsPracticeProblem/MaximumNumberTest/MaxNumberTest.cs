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
        public void TestMethodOne()
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
        public void TestMethodTWo()
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
        [Test]
        public void TestMethodThree()
        {
            Maximum maximum = new Maximum();
            //Arrange
            int firstValue = 20;
            int secondValue = 98;
            int thirdValue = 100;

            //Act
            int value = maximum.Number(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(thirdValue,value);
        }
        [Test]
        public void TestFloatFirstValue()
        {
            Maximum maximum = new Maximum();
            //Arrange
            float firstValue = 20.9f;
            float secondValue = 9.2f;
            float thirdValue =10.9f;

            //Act
           float value =maximum.MaximumFloat(firstValue,secondValue,thirdValue);
            //Assert
            Assert.AreEqual(firstValue, value);
        }

        [Test]
        public void TestFloatSecondValue()
        {
            Maximum maximum = new Maximum();
            //Arrange
            float firstValue = 20.9f;
            float secondValue = 90.2f;
            float thirdValue = 10.9f;

            //Act
            float value = maximum.MaximumFloat(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(secondValue,value);
        }
        [Test]
        public void TestFloatThirdValue()
        {
            Maximum maximum = new Maximum();
            //Arrange
            float firstValue = 20.9f;
            float secondValue = 90.2f;
            float thirdValue = 100.9f;

            //Act
            float value = maximum.MaximumFloat(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(thirdValue, value);
        }
    }
}

