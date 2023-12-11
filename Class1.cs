using System.Net;

namespace Scrape
{
    public class ScrapeWeb
    {

        public static string ScrapeWebpage(string address)
        {
            return GetHTML(address);
        }

        public static void ScarpeWebpage(string address, string filepath)
        {
            string html = GetHTML(address);
            File.WriteAllText(filepath, html);
        }

        private static string GetHTML(string url)
        {
            string result;
            WebClient client = new WebClient();
            result = client.DownloadString(url);

            return result;
        }

    }
}
