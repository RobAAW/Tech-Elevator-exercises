using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");

            string strDiscountAmount = Console.ReadLine();
            double discountPercent = double.Parse(strDiscountAmount)/100;




            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");

            string prices = Console.ReadLine();

            string[] priceArray = prices.Split(' ');

            for (int i = 0; i < priceArray.Length; i++)
            {
                //need some variables
                //declare variables for originalPrice, discountedPrice, amountOff
                decimal originalPrice = decimal.Parse(priceArray[i]);
                decimal discountedPrice = originalPrice * (1 - (decimal)discountPercent);
                decimal amountOff = originalPrice - discountedPrice;

                //Console.WriteLine("original price: " + originalPrice + "discounted price: " + discountedPrice + amountOff);

                Console.WriteLine($"Original Price: {originalPrice:C2} | Sale Price: {discountedPrice:C2} | Amount Off: {amountOff:C2}");


            }







        }
    }
}
