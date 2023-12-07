using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{
    //Create a C# program that intentionally throws a DivideByZeroException when dividing by zero. 
    //Catch the exception and handle it gracefully.

    class prog1
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter numerator number for division");
                int numerat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter denominator number for division");
                int denominat = Convert.ToInt32(Console.ReadLine());

                int result = DivideNumbers(numerat, denominat);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }
        static int DivideNumbers(int numerat, int denominat)
        {
            if (denominat == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return numerat / denominat;

        }
       // Console.ReadKey();
    }
}
