using Hilfe.Models;
using Microsoft.EntityFrameworkCore;

namespace Hilfe.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Issue> Issues { get; set; }
    }
}
