using System.Collections.Generic;
using Gauge.Data;
using Gauge.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gauge.Controllers
{
    //api/observations
    [Route("api/observations")]
    [ApiController]
    public class ObservationsController : ControllerBase
    {
        private readonly MockGaugeRepo _repository = new MockGaugeRepo();

        //GET apit/observations
        public ActionResult <IEnumerable<Observation>> GetAllObservations()
        {

        }

        //GET api/observations/{date}
        [HttpGet("{date}")]
        public ActionResult <Observation> GetObservationsByDate(string date)
        {

        }
    }
}