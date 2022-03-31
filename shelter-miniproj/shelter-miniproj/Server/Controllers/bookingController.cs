using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shelter_miniproj.Server.DataAccess;
using shelter_miniproj.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace shelter_miniproj.Server.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class bookingController : Controller
{
        bookingDataAccessLayer objbooking = new bookingDataAccessLayer();
       

        [HttpGet]
        [Route("api/booking/Index")]
        public IEnumerable<booking> Index()
        {
            return objbooking.GetAllBookings();
        }

        [HttpPost]
        [Route("api/booking/Details/{id}")]
        public List<booking> GetbookingData(string id)
        {
            return objbooking.GetbookingData(id);
        }

        [HttpPut]
        [Route("api/booking/Edit")]
        public void Edit([FromBody]booking booking)
        {
            objbooking.Updatebooking(booking);  
        }

        [HttpDelete]
        [Route("api/booking/Delete/{id}")]
        public void Delete(string id)
        {
            objbooking.Deletebooking(id);
        }

        [HttpGet]
        [Route("api/shelter/Getshelter")]
        public List<shelter>GetShelters()
        {
            return objbooking.GetShelterData();
        }



    }
}
