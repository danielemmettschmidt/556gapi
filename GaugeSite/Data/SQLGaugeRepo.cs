using System;
using System.Collections.Generic;
using System.Linq;
using Gauge.Models;

namespace Gauge.Data
{
    public class CheckDates
    {
        public DateTime Min;

        public DateTime Max; 

        public CheckDates(string input)
        {
            if(CheckChars(input) == true)
            {
                try
                {
                    this.Min = DateTime.ParseExact(input.Split("-")[0], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                    this.Max = DateTime.ParseExact(input.Split("-")[1], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception Ex)
                {
                    throw new Exception("Date conversion from \"" + input + "\" failed with message " + Ex.Message);
                }
            }
            else
            {
                throw new Exception(input + " is improperly formatted as the date string - the format is \"YYYYMMDD-YYYYMMDD\"");
            }
        }

        private bool CheckChars(string input)
        {
            foreach(char c in input)
            {
                switch (c)
                {
                    case '0':
                        break;
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case '-':
                        break;
                    default:
                        return false;
                }
            }

            if(input.Contains("-") == true && input.Split("-")[0].Length == 8 && input.Split("-")[1].Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class SQLGaugeRepo : IGaugeRepo
    {
        private readonly GaugeContext _context;

        public SQLGaugeRepo(GaugeContext context)
        {
            _context = context;
        }

        public IEnumerable<Observation> GetObservationsByDate(string dateString)
        {
            CheckDates checkdates = new CheckDates(dateString);

            return _context.Observations.Where<Observation>(o => o.WhenObserved.Date >= checkdates.Min && o.WhenObserved.Date <= checkdates.Max);
        }

        public IEnumerable<Observation> GetObservations()
        {
            return _context.Observations.Where<Observation>(o => o.WhenObserved.Date == DateTime.Today.AddDays(0 - 1));
        }
    }
}