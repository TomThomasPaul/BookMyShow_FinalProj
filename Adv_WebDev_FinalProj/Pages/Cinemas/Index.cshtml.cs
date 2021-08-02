using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adv_WebDev_FinalProj.Data;
using Adv_WebDev_FinalProj.Models;

namespace Adv_WebDev_FinalProj.Pages.Cinemas
{
    public class IndexModel : PageModel
    {
        private readonly Adv_WebDev_FinalProj.Data.Adv_WebDev_FinalProjContext _context;

        public IndexModel(Adv_WebDev_FinalProj.Data.Adv_WebDev_FinalProjContext context)
        {
            _context = context;
        }

        public IList<Cinema> Cinema { get;set; }

        public async Task OnGetAsync()
        {
            Cinema = await _context.Cinema
                .Include(c => c.Movie).ToListAsync();
        }
    }
}
