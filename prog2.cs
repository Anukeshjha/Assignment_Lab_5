using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{

// Write a program that attempts to access an array element at an index that is out of bounds.
// Use a try-catch block to handle the IndexOutOfRangeException.

    class prog2
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.Write("Enter an index to access the array: ");
            string userInput = Console.ReadLine();

            try
            {
                int index = int.Parse(userInput);
                int value = numbers[index];
                Console.WriteLine("Value at index " + index + ": " + value);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of bounds. Please enter a valid index.");
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer index.");
            }
            Console.ReadKey();
        }
        
    }
}
