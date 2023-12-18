﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Booking_System.Models
{
    internal class Booking
    {
        public int BookingID { get; set; }
        public int SpaceID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan BookingTime { get; set; }
        public string UserName { get; set; }

        public Space Space { get; set; }
    }

}
