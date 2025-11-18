using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class GradeCalculation
    {
        public static void GradeCalculation1()
        {
            Console.WriteLine("Enter marks of Physics, Chemistry, Biology, Mathematics, Computer:");
            int phy = Convert.ToInt32(Console.ReadLine());
            int chem = Convert.ToInt32(Console.ReadLine());
            int bio = Convert.ToInt32(Console.ReadLine());
            int math = Convert.ToInt32(Console.ReadLine());
            int comp = Convert.ToInt32(Console.ReadLine());

            float per = (phy + chem + bio + math + comp) / 5.0f;
            Console.WriteLine("Percentage = " + per + "%");

            if (per >= 90)
                Console.WriteLine("Grade A");
            else if (per >= 80)
                Console.WriteLine("Grade B");
            else if (per >= 70)
                Console.WriteLine("Grade C");
            else if (per >= 60)
                Console.WriteLine("Grade D");
            else if (per >= 40)
                Console.WriteLine("Grade E");
            else
                Console.WriteLine("Fail");
        }
    }
}
