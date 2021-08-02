using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adv_WebDev_FinalProj.Data;
using Adv_WebDev_FinalProj.Models;

namespace Adv_WebDev_FinalProj.Pages.Shows
{
    public class DetailsModel : PageModel
    {
        private readonly Adv_WebDev_FinalProj.Data.Adv_WebDev_FinalProjContext _context;

        public DetailsModel(Adv_WebDev_FinalProj.Data.Adv_WebDev_FinalProjContext context)
        {
            _context = context;
        }

        public Show Show { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Show
                .Include(s => s.Cinema).FirstOrDefaultAsync(m => m.ShowId == id);

            if (Show == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
