using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Create a C# program that uses a try-catch block to handle an exception when converting a string 
   //to an integer using int.Parse(). Handle the FormatException that may occur.
    class prog3
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            string userInput = Console.ReadLine();

            try
            {
                int number = int.Parse(userInput);
                Console.WriteLine("Successfully converted to integer: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadKey();
        }

    }
}
