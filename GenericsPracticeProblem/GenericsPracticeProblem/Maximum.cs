using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    public class Maximum
    {
        //UC1 check maximum number among three numbers 
        //Checking for the integer values 
        public int Number(int firstValue,int secondValue,int thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
           if(secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
           if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
        //UC2 check maximum number among three numbers 
        //Checking for the float values 
        //Checking for maximum float value 
        public  float MaximumFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            throw new Exception("first , second and third are same");
        }
        //method for finding maximun string value
        public string MaximunStringNumber(string firstValue, string secondValue, string thirdValue)
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
            throw new Exception("firstNumber, secondNumber and thirdNumber are same");
        }
    }
}
    
