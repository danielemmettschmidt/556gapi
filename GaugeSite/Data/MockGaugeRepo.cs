using System.Collections.Generic;
using Gauge.Models;

namespace Gauge.Data
{
    public class MockGaugeRepo : IGaugeRepo   
    {
        private static Observation mockob = new Observation{ Id = -1
                                    , IsPPR = 0
                                    , Price = -1
                                    , Rounds = -1
                                    , PPR = -1
                                    , ProductTitle = "MOCK"
                                    , ProductSource = "MOCK"
                                    , ScrapeUrl = "MOCK"
                                    , WriteDate = System.DateTime.Today
                                    };

        private static Observation replaceID(Observation ob, int id)
        {
            ob.Id = id;
            return ob;
        }

        public IEnumerable<Observation> GetObservations()
        {
            var observations = new List<Observation>
            {
                mockob, replaceID(mockob, -2), replaceID(mockob, -3)
            };

            return observations;

            throw new System.NotImplementedException();
        }

        public IEnumerable<Observation> GetObservationsByDate(string date)
        {
            var observations = new List<Observation>
            {
                mockob
            };

            return observations;
        }
    }
}