using MyClassLibrary1;
using System;

namespace MyCLient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape client = new Scrape();
            string scrapedPage = client.ScrapeWebpage("http://google.com");
            Console.WriteLine(scrapedPage);
            Console.WriteLine("Hello World!");
        }
    }
}
