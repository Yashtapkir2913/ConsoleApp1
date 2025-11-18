using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    public class Discount
    {
        public double GetDiscount(int price)
        {
            return price * 0.05;  
        }

        public double GetDiscount(int price, int percentage)
        {
            return price * percentage / 100.0;
        }

        public double GetDiscount(int price, bool isFestivalSeason)
        {
            if (isFestivalSeason)
                return price * 0.20;  

            return price * 0.10;      
        }
    }

    public class DiscountExample
    {
        public static void D1()
        {
            Discount discountCalculator = new Discount();
            double discount1 = discountCalculator.GetDiscount(1000);
            Console.WriteLine("Discount (5%): " + discount1);
            double discount2 = discountCalculator.GetDiscount(1000, 15);
            Console.WriteLine("Discount (15%): " + discount2);
            double discount3 = discountCalculator.GetDiscount(1000, true);
            Console.WriteLine("Festival Season Discount (20%): " + discount3);
            double discount4 = discountCalculator.GetDiscount(1000, false);
            Console.WriteLine("Non-Festival Season Discount (10%): " + discount4);
        }
    }
}//DiscountExample.D1();
