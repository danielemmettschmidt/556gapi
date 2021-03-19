using System;

namespace Gauge.Models
{
    public class Observation
    {        
        public int Id { get; set; }
        public byte IsPPR { get; set; }
        public double Price  { get; set; }
        public int Rounds  { get; set; }
        public double PPR  { get; set; }
        public string ProductTitle  { get; set; }
        public string ProductSource  { get; set; }
        public string ScrapeUrl  { get; set; }
        public DateTime WriteDate  { get; set; }
    }
}