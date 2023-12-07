using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assig_5
{

    class prog10
    {
        class NegativePriceException : Exception
        {
            public NegativePriceException(string message) : base(message) { }
        }

        class PriceTooHighException : Exception
        {
            public PriceTooHighException(string message) : base(message) { }
        }
        static void Main()
        {
            int[] shoppingCart = new int[10]; // Maximum number of items in the cart
            int cartSize = 0;
            const int maxPrice = 10000;

            while (true)
            {
                Console.Write("Enter the price of the item (or '0' to finish): ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    break; // Exit the loop when the user is done
                }

                try
                {
                    int price = int.Parse(input);

                    if (price < 0)
                    {
                        throw new NegativePriceException("NegativePriceException: Price entered is invalid.");
                    }

                    if (price > maxPrice)
                    {
                        throw new PriceTooHighException("PriceTooHighException: Price entered is too high.");
                    }

                    shoppingCart[cartSize] = price;
                    cartSize++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException: The input is not a valid price.");
                }
                catch (NegativePriceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PriceTooHighException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
            }
            int totalPrice = 0;

            for (int i = 0; i < cartSize; i++)
            {
                totalPrice += shoppingCart[i];
            }

            Console.WriteLine("Items in the cart:");
            for (int i = 0; i < cartSize; i++)
            {
                Console.WriteLine($"Item {i + 1}: ${shoppingCart[i]}");
            }
            Console.WriteLine("Total Price: $" + totalPrice);
            Console.ReadKey();
        }
      
    }
}