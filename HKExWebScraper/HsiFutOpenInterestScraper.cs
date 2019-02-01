using IronWebScraper;
using System;
using System.IO;
using System.Linq;
   
namespace HKExWebScraper
{
    class HsiFutOpenInterestScraper : WebScraper
    {
        public readonly string Output = Properties.Settings.Default.Output;
        public readonly string source = Properties.Settings.Default.Source;

        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request(source, Parse);
        }

        public override void Parse(Response response)
        {
            //Get the second table.
            var table = response.Css("table.table.migrate").ToArray()[1];
            var elements = table.InnerText.Split('\n');
            elements = elements.Where(x => !String.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).ToArray();

            var prev = new HsiFuturesMkyShrData { Week = elements[1], };
            var curr = new HsiFuturesMkyShrData { Week = elements[3], };
            int i = 4;
            prev.LongOI.Total = Double.Parse(elements[i + 1]);
            curr.LongOI.Total = Double.Parse(elements[i + 2]);

            prev.LongOI.PctOfMktOI = elements[i + 4];
            curr.LongOI.PctOfMktOI = elements[i + 5];

            prev.LongOI.Participant1 = elements[i + 7];
            curr.LongOI.Participant1 = elements[i + 8];

            prev.LongOI.Participant2 = elements[i + 10];
            curr.LongOI.Participant2 = elements[i + 11];

            prev.LongOI.Participant3 = elements[i + 13];
            curr.LongOI.Participant3 = elements[i + 14];

            prev.LongOI.Participant4 = elements[i + 16];
            curr.LongOI.Participant4 = elements[i + 17];

            prev.LongOI.Participant5 = elements[i + 19];
            curr.LongOI.Participant5 = elements[i + 20];

            prev.LongOI.Participant6 = elements[i + 22];
            curr.LongOI.Participant6 = elements[i + 23];

            prev.LongOI.Participant7 = elements[i + 25];
            curr.LongOI.Participant7 = elements[i + 26];

            prev.LongOI.Participant8 = elements[i + 28];
            curr.LongOI.Participant8 = elements[i + 29];

            prev.LongOI.Participant9 = elements[i + 31];
            curr.LongOI.Participant9 = elements[i + 32];

            prev.LongOI.Participant10 = elements[i + 34];
            curr.LongOI.Participant10 = elements[i + 35];

            i = 40;
            prev.ShortOI.Total = Double.Parse(elements[i + 1]);
            curr.ShortOI.Total = Double.Parse(elements[i + 2]);
            //i+3
            prev.ShortOI.PctOfMktOI = elements[i + 4];
            curr.ShortOI.PctOfMktOI = elements[i + 5];
            //i+6
            prev.ShortOI.Participant1 = elements[i + 7];
            curr.ShortOI.Participant1 = elements[i + 8];
            //i+9
            prev.ShortOI.Participant2 = elements[i + 10];
            curr.ShortOI.Participant2 = elements[i + 11];
            //i+12
            prev.ShortOI.Participant3 = elements[i + 13];
            curr.ShortOI.Participant3 = elements[i + 14];
            //i+15
            prev.ShortOI.Participant4 = elements[i + 16];
            curr.ShortOI.Participant4 = elements[i + 17];
            //i+18
            prev.ShortOI.Participant5 = elements[i + 19];
            curr.ShortOI.Participant5 = elements[i + 20];
            //i+21
            prev.ShortOI.Participant6 = elements[i + 22];
            curr.ShortOI.Participant6 = elements[i + 23];
            //i+24
            prev.ShortOI.Participant7 = elements[i + 25];
            curr.ShortOI.Participant7 = elements[i + 26];
            //i+27
            prev.ShortOI.Participant8 = elements[i + 28];
            curr.ShortOI.Participant8 = elements[i + 29];
            //i+30
            prev.ShortOI.Participant9 = elements[i + 31];
            curr.ShortOI.Participant9 = elements[i + 32];
            //i+33
            prev.ShortOI.Participant10 = elements[i + 34];
            curr.ShortOI.Participant10 = elements[i + 35];

            i = 76;
            prev.LongShortTO.Total = Double.Parse(elements[i + 1]);
            curr.LongShortTO.Total = Double.Parse(elements[i + 2]);
            //i+3
            prev.LongShortTO.PctOfMktTO = elements[i + 4];
            curr.LongShortTO.PctOfMktTO = elements[i + 5];
            //i+6
            prev.LongShortTO.Participant1 = elements[i + 7];
            curr.LongShortTO.Participant1 = elements[i + 8];
            //i+9
            prev.LongShortTO.Participant2 = elements[i + 10];
            curr.LongShortTO.Participant2 = elements[i + 11];
            //i+12
            prev.LongShortTO.Participant3 = elements[i + 13];
            curr.LongShortTO.Participant3 = elements[i + 14];
            //i+15
            prev.LongShortTO.Participant4 = elements[i + 16];
            curr.LongShortTO.Participant4 = elements[i + 17];
            //i+18
            prev.LongShortTO.Participant5 = elements[i + 19];
            curr.LongShortTO.Participant5 = elements[i + 20];
            //i+21
            prev.LongShortTO.Participant6 = elements[i + 22];
            curr.LongShortTO.Participant6 = elements[i + 23];
            //i+24
            prev.LongShortTO.Participant7 = elements[i + 25];
            curr.LongShortTO.Participant7 = elements[i + 26];
            //i+27
            prev.LongShortTO.Participant8 = elements[i + 28];
            curr.LongShortTO.Participant8 = elements[i + 29];
            //i+30
            prev.LongShortTO.Participant9 = elements[i + 31];
            curr.LongShortTO.Participant9 = elements[i + 32];
            //i+33
            prev.LongShortTO.Participant10 = elements[i + 34];
            curr.LongShortTO.Participant10 = elements[i + 35];

            i = 112;
            prev.LongTO.Total = Double.Parse(elements[i + 1]);
            curr.LongTO.Total = Double.Parse(elements[i + 2]);
            //i+3
            prev.LongTO.PctOfMktTO = elements[i + 4];
            curr.LongTO.PctOfMktTO = elements[i + 5];
            //i+6
            prev.LongTO.Participant1 = elements[i + 7];
            curr.LongTO.Participant1 = elements[i + 8];
            //i+9
            prev.LongTO.Participant2 = elements[i + 10];
            curr.LongTO.Participant2 = elements[i + 11];
            //i+12
            prev.LongTO.Participant3 = elements[i + 13];
            curr.LongTO.Participant3 = elements[i + 14];
            //i+15
            prev.LongTO.Participant4 = elements[i + 16];
            curr.LongTO.Participant4 = elements[i + 17];
            //i+18
            prev.LongTO.Participant5 = elements[i + 19];
            curr.LongTO.Participant5 = elements[i + 20];
            //i+21
            prev.LongTO.Participant6 = elements[i + 22];
            curr.LongTO.Participant6 = elements[i + 23];
            //i+24
            prev.LongTO.Participant7 = elements[i + 25];
            curr.LongTO.Participant7 = elements[i + 26];
            //i+27
            prev.LongTO.Participant8 = elements[i + 28];
            curr.LongTO.Participant8 = elements[i + 29];
            //i+30
            prev.LongTO.Participant9 = elements[i + 31];
            curr.LongTO.Participant9 = elements[i + 32];
            //i+33
            prev.LongTO.Participant10 = elements[i + 34];
            curr.LongTO.Participant10 = elements[i + 35];

            i = 148;
            prev.ShortTO.Total = Double.Parse(elements[i + 1]);
            curr.ShortTO.Total = Double.Parse(elements[i + 2]);
            //i+3
            prev.ShortTO.PctOfMktTO = elements[i + 4];
            curr.ShortTO.PctOfMktTO = elements[i + 5];
            //i+6
            prev.ShortTO.Participant1 = elements[i + 7];
            curr.ShortTO.Participant1 = elements[i + 8];
            //i+9
            prev.ShortTO.Participant2 = elements[i + 10];
            curr.ShortTO.Participant2 = elements[i + 11];
            //i+12
            prev.ShortTO.Participant3 = elements[i + 13];
            curr.ShortTO.Participant3 = elements[i + 14];
            //i+15
            prev.ShortTO.Participant4 = elements[i + 16];
            curr.ShortTO.Participant4 = elements[i + 17];
            //i+18
            prev.ShortTO.Participant5 = elements[i + 19];
            curr.ShortTO.Participant5 = elements[i + 20];
            //i+21
            prev.ShortTO.Participant6 = elements[i + 22];
            curr.ShortTO.Participant6 = elements[i + 23];
            //i+24
            prev.ShortTO.Participant7 = elements[i + 25];
            curr.ShortTO.Participant7 = elements[i + 26];
            //i+27
            prev.ShortTO.Participant8 = elements[i + 28];
            curr.ShortTO.Participant8 = elements[i + 29];
            //i+30
            prev.ShortTO.Participant9 = elements[i + 31];
            curr.ShortTO.Participant9 = elements[i + 32];
            //i+33
            prev.ShortTO.Participant10 = elements[i + 34];
            curr.ShortTO.Participant10 = elements[i + 35];

            i = 184;
            prev.Others.HsiFutTO = Double.Parse(elements[i + 1]);
            curr.Others.HsiFutTO = Double.Parse(elements[i + 2]);

            prev.Others.PctTotalCashMktTO = elements[i + 4];
            curr.Others.PctTotalCashMktTO = elements[i + 5];

            prev.Others.NumOfActExPt = Double.Parse(elements[i + 7]);
            curr.Others.NumOfActExPt = Double.Parse(elements[i + 8]);

            WriteToCsv(prev, curr);
        }

        private void WriteToCsv(HsiFuturesMkyShrData prev, HsiFuturesMkyShrData curr)
        {
            var lines = File.ReadAllLines(Output);

            if (lines.Any(x => x.Contains(prev.Week)))
            {
            }
            else
            {
                File.AppendAllText(Output, prev.ToString());
                File.AppendAllText(Output, Environment.NewLine);
            }
            if (lines.Any(x => x.Contains(curr.Week)))
            {
            }
            else
            {
                File.AppendAllText(Output, curr.ToString());
                File.AppendAllText(Output, Environment.NewLine);
            }
        }
    }
}