using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Implement a C# program that uses a custom exception class. Create a custom exception and 
    //throw it in your code when a specific condition is met.
    class prog4
    {
       
        class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }
        static void Main()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int number = int.Parse(userInput);

                if (number < 0)
                {
                    throw new CustomException("CustomException: The number cannot be negative.");
                }

                Console.WriteLine("You entered a non-negative number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
