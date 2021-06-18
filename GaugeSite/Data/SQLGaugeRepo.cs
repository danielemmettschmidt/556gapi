using System;
using System.Collections.Generic;
using System.Linq;
using Gauge.Models;

namespace Gauge.Data
{
    public partial class SQLGaugeRepo : IGaugeRepo
    {
        private readonly GaugeContext _context;

        public SQLGaugeRepo(GaugeContext context)
        {
            _context = context;
        }
    }
}