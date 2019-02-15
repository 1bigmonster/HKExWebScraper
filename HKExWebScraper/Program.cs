using System;

namespace HKExWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            try
            {
                logger.Info("Start the scraper.");
                var scraper = new HsiFutOpenInterestScraper();
                scraper.Start();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("Finish the scraper.");
            }
        }
    }
}
