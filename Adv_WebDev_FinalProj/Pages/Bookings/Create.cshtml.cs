using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Adv_WebDev_FinalProj.Data;
using Adv_WebDev_FinalProj.Models;

namespace Adv_WebDev_FinalProj.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly Adv_WebDev_FinalProj.Data.Adv_WebDev_FinalProjContext _context;

        public CreateModel(Adv_WebDev_FinalProj.Data.Adv_WebDev_FinalProjContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ShowId"] = new SelectList(_context.Set<Show>(), "ShowId", "ShowId");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
