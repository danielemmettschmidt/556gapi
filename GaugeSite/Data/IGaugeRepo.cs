using System.Collections.Generic;
using Gauge.Models;

namespace Gauge.Data
{
        public interface IGaugeRepo
        {
            IEnumerable<Observation> GetObservations();
            Observation GetObservationByDate(string date);
            
        }
}