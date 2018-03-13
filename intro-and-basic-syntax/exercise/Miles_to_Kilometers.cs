using System;

namespace Debit_Card_Number
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
			//We receive from the Console miles as double
            double miles = double.Parse(Console.ReadLine());
			//We convert miles to kilometers
            double kilometers = miles * 1.60934;
			//We print on console kilometers, formated to the second character
            Console.Write("{0:F2}", kilometers);
			Console.WriteLine();
        }
    }
}