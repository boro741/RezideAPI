using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezideAPI.Models
{
    public class TestData
    {
        private List<SeatBooking> SeatBooked = new List<SeatBooking>
        {
            new SeatBooking()
            {
                PID = 123456,
                SeatNo = "S271",
                availability = false
            },
            new SeatBooking()
            {
                PID = 123457,
                SeatNo = "S272",
                availability = false
            },
            new SeatBooking()
            {
                PID = 123458,
                SeatNo = "S273",
                availability = false
            }
        };

        public List<SeatBooking> Get()
        {
            return SeatBooked;
        }

        public SeatBooking Get(int PID)
        {
            return SeatBooked.First(t => t.PID == PID);
        }

        public void Add(SeatBooking newSeatBooking)
        {
            SeatBooked.Add(newSeatBooking);
        }

        public void Update(SeatBooking seatToUpdate)
        {
            SeatBooked.Remove(SeatBooked.First(t => t.PID == seatToUpdate.PID));
            Add(seatToUpdate);
        }

        public void Remove(int PID)
        {
            SeatBooked.Remove(SeatBooked.First(t => t.PID == PID));
        }

    }
}
