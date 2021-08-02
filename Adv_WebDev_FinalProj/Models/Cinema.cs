using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adv_WebDev_FinalProj.Models
{
    public class Cinema
    {
        public int CinemaId { get; set; }
        public string CinemaName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Rating { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public List<Show> Shows { get; set; }
     


    }
}
