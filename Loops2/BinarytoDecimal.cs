using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class BinarytoDecimal
    {
        public static void BinarytoDecimal1()
        {
            Console.Write("Enter binary number: ");
            string bin = Console.ReadLine();
            int dec = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[bin.Length - 1 - i] == '1')
                    dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine("Decimal: " + dec);
        }
    }
}
