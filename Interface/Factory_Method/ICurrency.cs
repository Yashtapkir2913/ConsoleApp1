using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface.Factory_Method
{

    public interface ICurrency
    {
        string GetSymbol();
    }


    public class Dollar : ICurrency
    {
        public string GetSymbol() => "Dollar Symbol";
    }

    public class Rupee : ICurrency
    {
        public string GetSymbol() => "Rupee Symbol";
    }

    public class Euro : ICurrency
    {
        public string GetSymbol() => "Euro Symbol";
    }


    public static class CurrencyFactory
    {
        public static ICurrency CreateCurrency(string type)
        {
            if (type == "usd")
            {
                return new Dollar();
            }
            else if (type == "inr")
            {
                return new Rupee();
            }
            else if (type == "eur")
            {
                return new Euro();
            }
            else
            {   
                return new Rupee();
            }
        }
    }

    class CurrencyTest
    {
        public static void M1()
        {
            ICurrency c1 = CurrencyFactory.CreateCurrency("usd");
            Console.WriteLine(c1.GetSymbol());   

            ICurrency c2 = CurrencyFactory.CreateCurrency("inr");
            Console.WriteLine(c2.GetSymbol());   

            ICurrency c3 = CurrencyFactory.CreateCurrency("eur");
            Console.WriteLine(c3.GetSymbol());   
        }
    }
}//CurrencyTest.M1();


