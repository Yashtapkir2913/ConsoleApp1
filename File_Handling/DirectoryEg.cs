using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.File_Handling
{
    class DirectoryEg
    {
        public static void M1()
        {
            string path = @"C:\A\B\C";
            Directory.CreateDirectory(path);
            Console.WriteLine("Folders A, B, and C created successfully in C drive!");

            string docxPath = Path.Combine(path, "docx");
            Directory.CreateDirectory(docxPath);
            Console.WriteLine("docx folder created inside C!");

            string filePath = Path.Combine(docxPath, "example.txt");
            File.WriteAllText(filePath, "Hello Yash! This text is written inside the docx folder.");
            Console.WriteLine("written successfully!");
        }
    }


}
