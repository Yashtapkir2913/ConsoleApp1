using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"FileLogger: {message}");
        }
    }

    public class DbLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"DbLogger: {message}");
        }
    }

   
    class ILogger1
    {
        public static void M1()
        {
            ILogger fileLogger = new FileLogger();
            fileLogger.Log("Saving to file...");

            ILogger dbLogger = new DbLogger();
            dbLogger.Log("Saving to database...");
        }
    }
}
