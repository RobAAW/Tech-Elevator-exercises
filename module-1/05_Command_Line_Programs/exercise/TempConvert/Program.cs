using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompt user to enter a temperature
            //whether it's in degrees (C)elsius or (F)ahrenheit
            //Fahrenheit to Celsius: Tc = (Tf - 32) / 1.8
            //Celsius to Fahrenheit: Tf = Tc * 1.8 + 32
            //Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

            Console.WriteLine("Please enter the temperature: ");
            string userTemp = Console.ReadLine();
            double temp = double.Parse(userTemp);

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?: ");
            string tempFormat = Console.ReadLine();
            char format = char.Parse(tempFormat);

            char userF = 'F';
            char userC = 'C';
            double newTemp = 0;
            char newFormat = 'n';

            bool fahrenheit = true;
            bool celsius = true;

            if (fahrenheit)
            {
                newFormat = userC;
            }
            if (celsius)
            {
                newFormat = userF;
            }

            if (format == userF)
            {
                newTemp = (temp - 32) / 1.8;
            }
            else if (format == userC)
            {
                newTemp = temp * 1.8 + 32; 
            }


            Console.WriteLine( userTemp + format + " is " + newTemp + newFormat);
        }
    }
}
