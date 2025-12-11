using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_vjwill77.Models;

namespace final_vjwill77.Pages_Participants
{
    public class DetailsModel : PageModel
    {
        private readonly final_vjwill77.Models.AppDbContext _context;

        public DetailsModel(final_vjwill77.Models.AppDbContext context)
        {
            _context = context;
        }

        public Participant Participant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants.Include(p => p.ParticipantCourses!).ThenInclude(pc => pc.Course).FirstOrDefaultAsync(m => m.ParticipantID == id);

            if (participant is not null)
            {
                Participant = participant;

                return Page();
            }

            return NotFound();
        }
    }
}
