using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Develop a program that simulates a simple calculator with basic arithmetic operations (addition, 
    //subtraction, multiplication, and division). Use exception handling to catch and handle various type of exceptions that may occur.
    class prog9
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break; // Exit the program
                }
                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    continue; // Ask for input again
                }

                double result = 0;
                bool validOperation = true;

                try
                {
                    Console.Write("Enter the first number: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case "1":
                            result = num1 + num2;
                            break;
                        case "2":
                            result = num1 - num2;
                            break;
                        case "3":
                            result = num1 * num2;
                            break;
                        case "4":
                            if (num2 == 0)
                            {
                                validOperation = false;
                                Console.WriteLine("Division by zero is not allowed.");
                            }
                            else
                            {
                                result = num1 / num2;
                            }
                            break;
                    }

                if (validOperation)
                {
                   Console.WriteLine("Result: " + result);
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
                Console.ReadKey();
            }
        }
    }

}
