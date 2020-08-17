using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreProject.Models;

namespace StoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private DataContext context;

        public MoviesController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("[action]")]
        public Movie GetMovie()
        {
            return context.Movies.OrderBy(p => p.MovieId).Last();
        }
    }
}
