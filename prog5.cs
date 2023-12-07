using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Build a C# program that demonstrates the use of multiple catch blocks for different exception 
    //types.Handle exceptions such as IndexOutOfRangeException, FormatException, and InvalidOperationException.
    class prog5
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter an index: ");
                int index = int.Parse(Console.ReadLine());

                int[] numbers = { 1, 2, 3, 4, 5 };
                int result = numbers[index]; //  IndexOutOfRangeException

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    throw new InvalidOperationException("InvalidOperationException: Division by zero is not allowed.");
                }

                int divisionResult = 10 / number; //  DivideByZeroException

                Console.WriteLine("Result: " + divisionResult);


            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of bounds. Please enter a valid index.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }
    }

}
