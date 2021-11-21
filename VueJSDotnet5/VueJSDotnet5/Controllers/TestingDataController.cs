using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueJSDotnet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestingDataController : ControllerBase
    {
        private static readonly int[] Summaries = new[]
       {
            1,2,3,4,5
        };

        private readonly ILogger<TestingDataController> _logger;

        public TestingDataController(ILogger<TestingDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}
