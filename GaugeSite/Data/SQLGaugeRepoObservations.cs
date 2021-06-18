using System;
using System.Collections.Generic;
using System.Linq;
using Gauge.Models;

namespace Gauge.Data
{
    public partial class SQLGaugeRepo : IGaugeRepo
    {
        public IEnumerable<Observation> GetObservationsByDate(string dateString)
        {
            CheckDates checkdates = new CheckDates(dateString);

            return _context.Observations.Where<Observation>(o => o.WhenObserved.Date >= checkdates.Min && o.WhenObserved.Date <= checkdates.Max);

            throw new NotImplementedException();
        }

        public IEnumerable<Observation> GetObservations()
        {
            return _context.Observations.Where<Observation>(o => o.WhenObserved.Date == DateTime.Today.AddDays(0 - 1));

            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateDateStat(DateStat dateStat)
        {
            if(dateStat == null)
            {
                throw new ArgumentNullException(nameof(dateStat));
            }

            _context.DateStats.Add(dateStat);
        }
    }
}