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

            Console.ReadLine();
        }
    }
    }

