using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adv_WebDev_FinalProj.Models
{
    public class Booking
    {

        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public Show Show { get; set; }
        public int ShowId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
    }
}


