using System;
using System.IO;
using System.Net;

namespace AddingRefrenceFromAssembly
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Admin\Documents\WriteText2.txt";
            string text = "using System.IO.File.WriteAllText";
            File.WriteAllText(path, text);
            WebClient client = new WebClient();
            string reply = client.DownloadString(@"https://silvabeat.netlify.app");
            File.WriteAllText(path, reply);
            Console.WriteLine(reply);
            Console.WriteLine("Hello World!");
        }
    }
}
