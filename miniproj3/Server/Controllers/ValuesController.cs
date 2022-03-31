using System;
using System.Collections.Generic;
using System.Linq;
using miniproj3.Shared;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using miniproj3.Server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace miniproj3.Server.Controllers
{   [ApiController]
    [Route("api/[controller]")]
    public class ShelterController : ControllerBase
    {
        private ShelterServices _shelterservice;

        public ShelterController(ShelterServices shelterserivce)
        {
            _shelterservice = shelterserivce;

        }
        /*
        [HttpGet]
        [Route("api/front/shelters")]
        public ActionResult<List<ShelterTest>> Get()
        {
            return _shelterservice.GetShelterTests();
        }
        */
        // GET: api/values
        [HttpGet]
        
        public ActionResult<List<Booking>> Get1()
        {
            return _shelterservice.GetShelters();
        }

        // GET api/values/5
        [HttpGet("{id:length(24)}")]
        public ActionResult<Booking> Get(string id)
        {
            return _shelterservice.GetShelter(id);
        }

        // POST api/values
        [HttpPost("")]
        public Booking Post(Booking shelter)
        {
            _shelterservice.postShelter(shelter);
            return shelter;
        }

        // PUT api/values/5
        [HttpPut("{id:length(24)}")]
        public Booking Put(string id, Booking newShelter)
        {

            return _shelterservice.putShelter(id, newShelter);
        }

        // DELETE api/values/5
        [HttpDelete("{id:length(24)}")]
        public Booking Delete(string id)
        {
            return _shelterservice.deleteShelter(id);
        }


    }/*
    [ApiController]
    [Route("api/[controller]")]
    public class Shelter1Controller : ControllerBase
    {
        private ShelterServices1 _shelterservice;
        public Shelter1Controller(ShelterServices1 shelterservice)
        {
            _shelterservice = shelterservice;
        }

        [HttpGet]
        public ActionResult<List<ShelterTest>> Get()
        {
            return _shelterservice.GetShelterTests();
        }

    }
    */
}
