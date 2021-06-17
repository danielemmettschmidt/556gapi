using System.Collections.Generic;
using AutoMapper;
using Gauge.Data;
using Gauge.DTOs;
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
        private readonly IMapper _mapper;

        public ObservationsController(IGaugeRepo repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        //private readonly MockGaugeRepo _repository = new MockGaugeRepo();
        
        //GET apit/observations
        [HttpGet]
        public ActionResult <IEnumerable<ObservationRead>> GetObservations()
        {
            var observationItems = _repository.GetObservations();

             return Ok(this._mapper.Map<IEnumerable<ObservationRead>>(observationItems));

        }


        //GET api/observations/{date}
        [HttpGet("{date}")]
        public ActionResult <ObservationRead> GetObservationsByDate(string date)
        {            
            var observationItems = _repository.GetObservationsByDate(date);
            return Ok(this._mapper.Map<IEnumerable<ObservationRead>>(observationItems));
        }
    }
}