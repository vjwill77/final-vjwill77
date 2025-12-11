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
    public class IndexModel : PageModel
    {
        private readonly final_vjwill77.Models.AppDbContext _context;

        public IndexModel(final_vjwill77.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Participant> Participant { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            var query = _context.Participants.Include(p => p.ParticipantCourses!).ThenInclude(pc => pc.Course).Select(p => p);
            if (!string.IsNullOrEmpty(CurrentSearch))
                {
                query = query.Where(p => p.FirstName.ToUpper().Contains(CurrentSearch.ToUpper()) || p.LastName.ToUpper().Contains(CurrentSearch.ToUpper()));
                }

            switch (CurrentSort)
            {
            case "first_asc":
                query = query.OrderBy(p => p.FirstName);
                break;
            case "first_desc":
                query = query.OrderByDescending(p => p.FirstName);
                break;
            }
        
            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);
            Participant = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); 
        }
    }
}
