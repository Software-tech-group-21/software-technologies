using System;

namespace Debit_Card_Number
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            //input
            //We recieve from the Consone miles as double
            double a = double.Parse(Console.ReadLine());

            //calculation
            //We convert miles to kilometers
            double b = a * 1.60934;

            //output
            //We print on console kilometers, formated to the second character
            Console.Write("{0:F2}", b);
            Console.ReadLine();
        }
    }
}