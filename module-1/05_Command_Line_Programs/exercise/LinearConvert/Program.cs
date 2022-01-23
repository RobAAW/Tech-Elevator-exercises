using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that converts meters to feet and vice-versa
            //foot to meter conversion
            //m = f * 0.3048
            //meter to foot conversion
            //f = m * 3.2808399
            //prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet. Convert the length to the opposite measurement, and display the old and new measurements to the console.
            //Please enter the length: 58
            //Is the measurement in (m)eter, or(f)eet? f
            //58f is 17m

            Console.WriteLine("Please enter the length: ");
            string userMeasure = Console.ReadLine();
            double measure = double.Parse(userMeasure);

            Console.WriteLine("Is the measurement in (m)eter, or(f)eet?: ");
            string measureFormat = Console.ReadLine();
            char format = char.Parse(measureFormat);

            char userF = 'f';
            char userM = 'm';
            double newMeasure = 0;
            char newFormat = '0';

            if (format == 'f')
            {
                newFormat = userM;
            }
            if (format == 'm')
            {
                newFormat = userF;
            }

            if (format == userF)
            {
                newMeasure = (int)(measure * 0.3048);
            }
            else if (format == userM)
            {
                newMeasure = (int)(measure * 3.2808399);
            }


            Console.WriteLine(userMeasure + format + " is " + newMeasure + newFormat +".");

            //Console.WriteLine("Hello World!");
        }
    }
}
