using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Adv_WebDev_FinalProj.Models;

namespace Adv_WebDev_FinalProj.Data
{
    public class Adv_WebDev_FinalProjContext : DbContext
    {
        public Adv_WebDev_FinalProjContext (DbContextOptions<Adv_WebDev_FinalProjContext> options)
            : base(options)
        {
        }

        public DbSet<Adv_WebDev_FinalProj.Models.Booking> Booking { get; set; }

        public DbSet<Adv_WebDev_FinalProj.Models.Cinema> Cinema { get; set; }

        public DbSet<Adv_WebDev_FinalProj.Models.Movie> Movie { get; set; }

        public DbSet<Adv_WebDev_FinalProj.Models.Show> Show { get; set; }
    }
}
