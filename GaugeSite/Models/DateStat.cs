using System;
using System.ComponentModel.DataAnnotations;

namespace Gauge.Models
{
    public class DateStat
    {        
        [Key]
        public int DateStatId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double PPRMax { get; set; }
      
        [Required]
        public double PPRMin { get; set; }

        [Required]
        public double PPRAverage { get; set; }

        [Required]
        public double PPRMedian { get; set; }

        [Required]
        public double PPRMode { get; set; }

        public double? PriceMax { get; set; }
      
        public double? PriceMin { get; set; }

        public double? PriceAverage { get; set; }

        public double? PriceMedian { get; set; }

        public double? PriceMode { get; set; }

        public double? RoundsMax { get; set; }
      
        public double? RoundsMin { get; set; }

        public double? RoundsAverage { get; set; }

        public double? RoundsMedian { get; set; }

        public double? RoundsMode { get; set; }

        [Required]
        public bool IsCarriedOverFromPriorDay { get; set; }
    }
}