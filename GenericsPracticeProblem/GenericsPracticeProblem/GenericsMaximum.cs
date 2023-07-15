using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{

    //Refactor code 2
   public class GenericsMaximum<T>where T :IComparable
    {
            public T firstValue;
            public T secondValue;
            public T thirdValue;

            public GenericsMaximum(T firstvalue, T secondvalue, T thirdvalue)
            {
                this.firstValue = firstvalue;
                this.secondValue = secondvalue;
                this.thirdValue = thirdvalue;
            }
        public static T Number(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
        public T MaxMethod()
        {
            T result = GenericsMaximum<T>.Number(this.firstValue, this.secondValue, this.thirdValue);
            return result;
        }

    }
}


