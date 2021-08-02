using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adv_WebDev_FinalProj.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public DateTime ShowDate { get; set; }
        public Movie Movie { get; set; }
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
