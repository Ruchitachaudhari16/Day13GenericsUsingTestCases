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
            int firstvalue = 100;
            int secondvalue = 20;
            int thirdvalue = 98;

            //Act
            int value = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(firstvalue, value);
        }
    }
}

