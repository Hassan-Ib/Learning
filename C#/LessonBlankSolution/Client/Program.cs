using ScrapeWeb;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape client = new Scrape();
            string scrapedPage = client.ScrapeWebpage("http://google.com");
            Console.WriteLine(scrapedPage);
            Console.ReadLine();
        }
    }
}
