using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RezideAPI.Models;

namespace RezideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatBookingController : Controller
    {

        private Models.TestData _testData;
        public SeatBookingController(TestData testData)
        {
            _testData = testData;
        }
        // GET api/SeatBooking
        [HttpGet]
        public ActionResult<IEnumerable<SeatBooking>> Get()
        {
            return _testData.Get();
        }

        // GET api/SeatBooking/5
        [HttpGet("{PID}")]
        public ActionResult<SeatBooking> Get(int PID)
        {
            return _testData.Get(PID);
        }

        // POST api/SeatBooking
        [HttpPost]
        public void Post([FromBody] SeatBooking value)
        {
            _testData.Add(value);
        }

        // PUT api/RezideAPI/5
        [HttpPut("{PID}")]
        public void Put(int PID, [FromBody] SeatBooking value)
        {
            _testData.Update(value);
        }

        // DELETE api/SeatBooking/5
        [HttpDelete("{PID}")]
        public void Delete(int PID)
        {
            _testData.Remove(PID);
        }
    }
}