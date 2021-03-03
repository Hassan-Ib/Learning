using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\Admin\Documents\";
                string fileName = "ErrorHandlingCSharp.txt";
                File.WriteAllText(path + fileName, "hello hassan pelumi.");
                //string content = @"C:\Users\Admin\Documents\ExceptionLession.txt";
                string fileContent = File.ReadAllText(path + fileName);
                Console.WriteLine(fileContent);
            }
            catch (Exception ex) // Exception is an new object class with message and methods
            { 

                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
