using System;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = @"ALTER USER 'root'@'localhost' IDENTIFIED BY 'Awesomewife1995';";
           
            string path = @"C:\mySql-init.txt";
            File.WriteAllText(path, content);
            Console.WriteLine("Hello World!");
        }
    }
}
