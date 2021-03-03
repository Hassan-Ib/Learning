using System;
using System.IO;
using System.Net;

namespace MyClassLibrary1
{
    public class Scrape
    {

        private string GetWebPage(string url) {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
        public string ScrapeWebpage(string url) {
            return GetWebPage(url);
        }

        public string ScrapeWebpage(string url, string filePath) {
            string reply = GetWebPage(url);
            File.WriteAllText(filePath, reply);
            return reply;
        }

    }
}
