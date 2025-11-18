using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class CountNotes
    {
        public static void CountNotes1()
        {
            Console.Write("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                amount %= note;
                if (count > 0)
                    Console.WriteLine(note + " : " + count);
            }
        }
    }
}
