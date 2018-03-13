using System;

namespace Debit_Card_Number
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.Write("{0:F2}", kilometers);
            Console.ReadLine();
        }
    }
}