using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Develop a C# program that demonstrates how to use the throw statement to rethrow an 
    //exception.Catch the rethrown exception and handle it appropriately.
    class prog8
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentException("Input should be a non-negative number.");
                }

                Console.WriteLine("You entered a non-negative number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException: " + ex.Message);
                Console.Write("Do you want to rethrow the exception? (yes/no): ");
                string response = Console.ReadLine();

                if (response.ToLower() == "yes")
                {
                    throw; // Rethrow the caught exception
                }
                else
                {
                    Console.WriteLine("Exception was handled.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
    
}
