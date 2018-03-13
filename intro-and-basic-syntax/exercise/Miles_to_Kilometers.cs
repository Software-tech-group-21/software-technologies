using System;

namespace Debit_Card_Number
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = a * 1.60934;
            Console.Write("{0:F2}", b);
            Console.ReadLine();
        }
    }
}