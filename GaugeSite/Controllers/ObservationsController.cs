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
        private readonly IGaugeRepo _repository;

        public ObservationsController(IGaugeRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockGaugeRepo _repository = new MockGaugeRepo();
        
        //GET apit/observations
        [HttpGet]
        public ActionResult <IEnumerable<Observation>> GetObservations()
        {
            var commandItems = _repository.GetObservations();

            return Ok(commandItems);

        }


        //GET api/observations/{date}
        [HttpGet("{date}")]
        public ActionResult <Observation> GetObservationsByDate(string date)
        {            
            var commandItems = _repository.GetObservationByDate(date);
            return Ok(commandItems);
        }
    }
}