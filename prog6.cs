using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Create a C# program that includes nested try-catch blocks. Throw an exception in an inner block 
    //and catch it in the outer block.Explain the flow of execution.
    class prog6
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                int numerator = int.Parse(Console.ReadLine());

                try
                {
                    Console.Write("Enter another number (denominator): ");
                    int denominator = int.Parse(Console.ReadLine());

                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("Inner Block: Division by zero is not allowed.");
                    }

                    int result = numerator / denominator;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Inner Block: Invalid input. Please enter a valid integer for the denominator.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Outer Block: Invalid input. Please enter a valid integer for the numerator.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer Block: An unexpected error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
