using System.Collections.Generic;
using Gauge.Models;

namespace Gauge.Data
{
        public interface IGaugeRepo
        {
            IEnumerable<Observation> GetAppCommands();
            Observation GetObservationByID(int id);
            
        }
}