using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maximum maximum = new Maximum();
            
            Console.WriteLine("Enter the FirstNumber");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ThirdNumber");
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            int val = maximum.Number(firstValue, secondValue, thirdValue);
            Console.WriteLine("{0} is largest number ", val);
            Console.ReadLine();

            //UC2
            Maximum max = new Maximum();
            Console.WriteLine("Find maximum  number among 3 float Values ");
            //Maximum number between three float values 
            //It will return First maximum float value
            float maxNumberOne = max.MaximumFloat(20.9f, 1.8f, 20.3f);
            Console.WriteLine("Maximum float number is" + maxNumberOne);

            //It will return Second maximum float value
            float maxNumberTwo = max.MaximumFloat(1.8f, 20.9f, 20.3f);
            Console.WriteLine("Maximum float number is:" + maxNumberTwo);

            //It will return Third maximum float value
            float maxNumberThree = max.MaximumFloat(1.8f, 20.3f, 20.9f);
            Console.WriteLine("Maximum float number is:" + maxNumberThree);

            //UC3
            Console.WriteLine("Find maximum  string among 3 string Values ");
            Maximum maxim =new Maximum();
            //It will return maximum string value among 3 Strings.
            string maxStringOne = maxim.MaximunStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum string is" + maxStringOne);

            string maxStringTwo = maxim.MaximunStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum string is" + maxStringTwo);


            string maxStringThree = maxim.MaximunStringNumber("Banana", "Apple", "Peach");
            Console.WriteLine("Maximum string is" + maxStringThree);

            Console.ReadLine();
        }
    }
    }

