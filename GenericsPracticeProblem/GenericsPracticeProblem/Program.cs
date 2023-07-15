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
            Console.WriteLine("-------------------------------------------");

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
            Console.WriteLine("---------------------------------------------------");

            //UC3
            Console.WriteLine("Find maximum  string among 3 string Values ");
            Maximum maxim = new Maximum();
            //It will return maximum string value among 3 Strings.
            string maxStringOne = maxim.MaximunStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum string is" + maxStringOne);

            string maxStringTwo = maxim.MaximunStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum string is" + maxStringTwo);


            string maxStringThree = maxim.MaximunStringNumber("Banana", "Apple", "Peach");
            Console.WriteLine("Maximum string is" + maxStringThree);
            Console.WriteLine("-----------------------------------------------");

            //Refactor-1
            Maximum maximu = new Maximum();
            Console.WriteLine("Please Enter the FirstValue:");
            var one = Console.ReadLine();
            Console.WriteLine("Please Enter the SecondValue:");
            var two = Console.ReadLine();
            Console.WriteLine("Please Enter the ThirdValue:");
            var three = Console.ReadLine();
            var Value = maximum.Number(one, two, three);
            Console.WriteLine("{0} is greater", Value);
            Console.WriteLine("-----------------------------------------------------");
            //Refactor-2  code 

            int numberOne = 100, numberTwo = 200, numberThree = 800;
            float fOne = 30.9f, fTwo = 8.5f, fThree = 10.7f;
            string wordOne = "Ruchita", wordTwo = "Nitya", wordThree = "Siya";
            GenericsMaximum<int> Genericsmaximum = new GenericsMaximum<int>(numberOne, numberTwo, numberThree);
            int values = Genericsmaximum.MaxMethod();
            Console.WriteLine("{0} is the largest", values);

            GenericsMaximum<float> maximum_one = new GenericsMaximum<float>(fOne, fTwo, fThree);
            float result = maximum_one.MaxMethod();
            Console.WriteLine("{0} is the largest", result);

            GenericsMaximum<string> maximum_two = new GenericsMaximum<string>(wordOne, wordTwo, wordThree);
            string output = maximum_two.MaxMethod();
            Console.WriteLine("{0} is the largest", output);


            Console.ReadLine();
        }


    }
}
    

