using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adv_WebDev_FinalProj.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }

        public List<Cinema> Cinemas { get; set; }

        public List<Show> Shows { get; set; }


    }



}


