using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vega.Core.Models;
using Vega.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Vega.Controllers
{
    public class FeatureController
    {
        private readonly VegaDbContext _context;

        public FeatureController(VegaDbContext context)
        {
            this._context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<Feature>> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();

            return features;
        }

    }
}
