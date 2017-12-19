using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeApp2
{
    class Program
    {
        static void Main(string[] args)
        {//Write a program which takes two numbers from the console and displays the maximum of the two.

            double[] numArr = new double[2]; //initialize a number array to catch values.  

            for (var i = 0; i <numArr.Length; i++) //create a loop to ask for values and do validation with TryParse
            {
                Console.WriteLine("Please enter a number: ");
               
                while (double.TryParse(Console.ReadLine(), out numArr[i]) == false || numArr[i]<0) //protect against bad input
                {
                    Console.WriteLine("Sorry, invalid input.  Please try again.");
                }


                Console.WriteLine("You entered {0}", numArr[i]);
            }

            //determine which number in the array is the max and min

            var max = numArr.Max();
            var min = numArr.Min();

            Console.WriteLine("The highest number was {0}", max);
            Console.WriteLine("The lowest number was {0}", min);
            Console.ReadKey();

        }
    }
}
