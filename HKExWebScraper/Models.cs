using System;

namespace HKExWebScraper
{
    /// <summary>
    /// MARKET SHARE DATA ON HSI FUTURES
    /// </summary>
    public class HsiFuturesMkyShrData
    {
        public DateTime Timestamp { get; private set; }
        public string Week { get; set; }
        public Top10ExPtLongOI LongOI { get; set; }
        public Top10ExPtShortOI ShortOI { get; set; }
        public Top10ExPtLongShortTO LongShortTO { get; set; }
        public Top10ExPtLongTO LongTO { get; set; }
        public Top10ExPtShortTO ShortTO { get; set; }
        public Others Others { get; set; }

        public HsiFuturesMkyShrData()
        {
            this.Timestamp = DateTime.Now;
            this.LongOI = new Top10ExPtLongOI();
            this.ShortOI = new Top10ExPtShortOI();
            this.LongShortTO = new Top10ExPtLongShortTO();
            this.LongTO = new Top10ExPtLongTO();
            this.ShortTO = new Top10ExPtShortTO();
            this.Others = new Others();
        }

        public override string ToString()
        {
            return $"{Timestamp.ToString("yyyyMMdd-HHmmss")},{Week},{LongOI.ToString()},{ShortOI.ToString()},{LongShortTO.ToString()},{LongTO.ToString()},{ShortTO.ToString()},{Others.ToString()}";
        }
    }

    public class Others
    {
        /// <summary>
        /// Hang Seng Index Futures Turnover(Contracts)**
        /// </summary>
        public double HsiFutTO { get; set; }
        /// <summary>
        ///  % of Total Cash Market Turnover***
        /// </summary>
        public string PctTotalCashMktTO { get; set; }
        /// <summary>
        ///  Number of Active Exchange Participants
        /// </summary>
        public double NumOfActExPt { get; set; }

        public override string ToString()
        {
            return $"{HsiFutTO},{PctTotalCashMktTO},{NumOfActExPt},";
        }
    }

    /// <summary>
    ///  Top 10 Exchange Participants' Short Turnover (Contracts)
    /// </summary>
    public class Top10ExPtShortTO
    {
        public double Total { get; set; }
        /// <summary>
        ///   % of Market Short Turnover*
        /// </summary>
        public string PctOfMktTO { get; set; }
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Participant3 { get; set; }
        public string Participant4 { get; set; }
        public string Participant5 { get; set; }
        public string Participant6 { get; set; }
        public string Participant7 { get; set; }
        public string Participant8 { get; set; }
        public string Participant9 { get; set; }
        public string Participant10 { get; set; }

        public override string ToString()
        {
            return $"{Total},{PctOfMktTO},{Participant1},{Participant2},{Participant3},{Participant4},{Participant5},{Participant6},{Participant7},{Participant8},{Participant9},{Participant10}";
        }
    }

    /// <summary>
    ///  Top 10 Exchange Participants' Long Turnover (Contracts)
    /// </summary>
    public class Top10ExPtLongTO
    {
        public double Total { get; set; }
        /// <summary>
        ///   % of Market Long Turnover*
        /// </summary>
        public string PctOfMktTO { get; set; }
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Participant3 { get; set; }
        public string Participant4 { get; set; }
        public string Participant5 { get; set; }
        public string Participant6 { get; set; }
        public string Participant7 { get; set; }
        public string Participant8 { get; set; }
        public string Participant9 { get; set; }
        public string Participant10 { get; set; }

        public override string ToString()
        {
            return $"{Total},{PctOfMktTO},{Participant1},{Participant2},{Participant3},{Participant4},{Participant5},{Participant6},{Participant7},{Participant8},{Participant9},{Participant10}";
        }
    }

    /// <summary>
    ///   Top 10 Exchange Participants' Long and Short Turnover (Contracts)
    /// </summary>
    public class Top10ExPtLongShortTO
    {
        public double Total { get; set; }
        /// <summary>
        ///  % of Market Long and Short Turnover*
        /// </summary>
        public string PctOfMktTO { get; set; }
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Participant3 { get; set; }
        public string Participant4 { get; set; }
        public string Participant5 { get; set; }
        public string Participant6 { get; set; }
        public string Participant7 { get; set; }
        public string Participant8 { get; set; }
        public string Participant9 { get; set; }
        public string Participant10 { get; set; }

        public override string ToString()
        {
            return $"{Total},{PctOfMktTO},{Participant1},{Participant2},{Participant3},{Participant4},{Participant5},{Participant6},{Participant7},{Participant8},{Participant9},{Participant10}";
        }
    }

    /// <summary>
    ///   Top 10 Exchange Participants' Short Open Interest (Contracts, End-period)
    /// </summary>
    public class Top10ExPtShortOI
    {
        public double Total { get; set; }
        /// <summary>
        /// % of Market Open Interest*
        /// </summary>
        public string PctOfMktOI { get; set; }
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Participant3 { get; set; }
        public string Participant4 { get; set; }
        public string Participant5 { get; set; }
        public string Participant6 { get; set; }
        public string Participant7 { get; set; }
        public string Participant8 { get; set; }
        public string Participant9 { get; set; }
        public string Participant10 { get; set; }

        public override string ToString()
        {
            return $"{Total},{PctOfMktOI},{Participant1},{Participant2},{Participant3},{Participant4},{Participant5},{Participant6},{Participant7},{Participant8},{Participant9},{Participant10}";
        }
    }

    /// <summary>
    ///  Top 10 Exchange Participants' Long Open Interest (Contracts, End-period)
    /// </summary>
    public class Top10ExPtLongOI
    {
        public double Total { get; set; }
        /// <summary>
        /// % of Market Open Interest*
        /// </summary>
        public string PctOfMktOI { get; set; }
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Participant3 { get; set; }
        public string Participant4 { get; set; }
        public string Participant5 { get; set; }
        public string Participant6 { get; set; }
        public string Participant7 { get; set; }
        public string Participant8 { get; set; }
        public string Participant9 { get; set; }
        public string Participant10 { get; set; }

        public override string ToString()
        {
            return $"{Total},{PctOfMktOI},{Participant1},{Participant2},{Participant3},{Participant4},{Participant5},{Participant6},{Participant7},{Participant8},{Participant9},{Participant10}";
        }
    }
}
