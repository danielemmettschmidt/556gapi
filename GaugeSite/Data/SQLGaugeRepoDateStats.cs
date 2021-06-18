using System;
using System.Collections.Generic;
using System.Linq;
using Gauge.Models;

namespace Gauge.Data
{
    public partial class SQLGaugeRepo : IGaugeRepo
    {
        public IEnumerable<DateStat> GetDateStatsByDate(string date)
        {
            CheckDates checkdates = new CheckDates(date);

            return _context.DateStats.Where<DateStat>(o => o.Date.Date >= checkdates.Min && o.Date.Date <= checkdates.Max);

            throw new NotImplementedException();
        }

        public IEnumerable<DateStat> GetDateStats()
        {
            return _context.DateStats.Where<DateStat>(o => o.Date.Date == DateTime.Today.AddDays(0 - 1));

            throw new NotImplementedException();
        }
    }
}