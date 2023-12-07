using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Implement a program that divides two numbers entered by the user. Handle exceptions like 
    // division by zero and invalid input.Continue to prompt the user for valid input until a valid division is performed.


    class prog7
    {
        static void Main()
        {
            bool validInput = false;
            double result = 0.0;

            while (!validInput)
            {
                try
                {
                    Console.Write("Enter the numerator: ");
                    double numerator = double.Parse(Console.ReadLine());

                    Console.Write("Enter the denominator: ");
                    double denominator = double.Parse(Console.ReadLine());

                    if (denominator == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed. Please enter a non-zero denominator.");
                    }
                    else
                    {
                        result = numerator / denominator;
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers for both numerator and denominator.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
            }

            Console.WriteLine("Result of the division: " + result);
            Console.ReadKey();
        }
       
    }
}
