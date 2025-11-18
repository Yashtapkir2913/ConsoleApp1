using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IReadable
    {
        void Read();
    }

    public interface IWritable
    {
        void Write();
    }

    public class Document : IReadable, IWritable
    {
        public void Read() => Console.WriteLine("Reading document...");
        public void Write() => Console.WriteLine("Writing document...");
    }

    
    class IReadable1
    {
        public static void M1()
        {
            Document doc = new Document();
            doc.Read();
            doc.Write();
        }
    }
}//IReadable1.M1();
