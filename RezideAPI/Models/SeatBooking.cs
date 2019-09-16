using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezideAPI.Models
{
    public class SeatBooking
    {
        public int PID { get; set; }
        public string SeatNo { get; set; }
        public bool availability { get; set; } = true;
    }
}
