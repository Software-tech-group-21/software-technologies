using System;

namespace Debit_Card_Number
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            //input
            double a = double.Parse(Console.ReadLine());
            //calc
            double b = a * 1.60934;
            //output
            Console.Write("{0:F2}", b);
            Console.ReadLine();
        }
    }
}