using System;
using System.ComponentModel.DataAnnotations;

namespace Gauge.Models
{
    public class Observation
    {        
        [Key]
        public long ObsId { get; set; }

        public byte IsPPR { get; set; }

        public double Price  { get; set; }

        public int Rounds  { get; set; }

        public double PPR  { get; set; }

        [MaxLength(35)]
        public string ProductTitle  { get; set; }

        [MaxLength(15)]
        public string ProductSource  { get; set; }

        [MaxLength(50)]
        public string ScrapeUrl  { get; set; }

        public DateTime WhenObserved  { get; set; }

        public long BackupID  { get; set; }
    }
}