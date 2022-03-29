using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shelterminiproj.Shared;
using System.Text.Json.Serialization;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shelterminiproj.Server.Controllers
{
    [Route("[Controller]")]
    public class ShelterController : Controller
    {
       
        
            private readonly ILogger<ShelterController> _logger;

            public ShelterController(ILogger<ShelterController> logger)
            {
                _logger = logger;
            }

        [HttpGet]
        public IEnumerable<Shelter> Get()
        {

            return SampleShelters.list1;

        }
    }
        
}
