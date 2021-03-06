using System.Collections.Generic;
using AutoMapper;
using Gauge.Data;
using Gauge.DTOs;
using Gauge.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gauge.Controllers
{
    //api/observations
    [Route("api/datestats")]
    [ApiController]
    public class DateStatsController : ControllerBase
    {
        private readonly IGaugeRepo _repository;
        private readonly IMapper _mapper;

        public DateStatsController(IGaugeRepo repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        //private readonly MockGaugeRepo _repository = new MockGaugeRepo();
        
        //GET api/datestats
        [HttpGet]
        public ActionResult <IEnumerable<DateStat>> GetDateStats()
        {
            var observationItems = _repository.GetDateStats();

             return Ok(this._mapper.Map<IEnumerable<ObservationRead>>(observationItems));

        }


        //GET api/datestats/{date}
        [HttpGet("{date}")]
        public ActionResult <DateStat> GetDateStatsByDate(string date)
        {            
            var observationItems = _repository.GetDateStatsByDate(date);
            return Ok(this._mapper.Map<IEnumerable<ObservationRead>>(observationItems));
        }

        //POST api/datestats
        [HttpPost]
        public ActionResult <DateStat> CreateDateStat(DateStatCreateDTO dateStatCreateDTO)
        {
            var datestatModel = _mapper.Map<DateStat>(dateStatCreateDTO);

            this._repository.CreateDateStat(datestatModel)
        }
    }
}