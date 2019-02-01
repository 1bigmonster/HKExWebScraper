using System;

namespace HKExWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var scraper = new HsiFutOpenInterestScraper();
                scraper.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
