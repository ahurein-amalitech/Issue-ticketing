using Hilfe.Data;
using Hilfe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hilfe.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IssueDbContext _context;        
        public IEnumerable<Issue> Issues { get; set; } = Enumerable.Empty<Issue>();
        public IndexModel(IssueDbContext context)
        {
            _context = context;
        }

        public async void OnGet()
        {
             Issues = await _context.Issues.Where(i => i.Completed == null)
                .OrderByDescending(i => i.Created).ToListAsync();
        }
    }
}