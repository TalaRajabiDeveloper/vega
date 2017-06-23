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
    public class MakesController
    {
        private readonly VegaDbContext _context;

        public MakesController(VegaDbContext context)
        {
            this._context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            var makes = await _context
                .Makes
                //.Include(m => m.Models)
                .ToListAsync();

            return makes;
        }

        [HttpGet("/api/models")]
        public async Task<IEnumerable<Model>> GetModels()
        {
            var models = await _context
                .Models
                .ToListAsync();

            return models;
        }

    }
}
