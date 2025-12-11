using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using final_vjwill77.Models;

namespace final_vjwill77.Pages_Participants
{
    public class CreateModel : PageModel
    {
        private readonly final_vjwill77.Models.AppDbContext _context;

        public CreateModel(final_vjwill77.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Participant Participant { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Participants.Add(Participant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
