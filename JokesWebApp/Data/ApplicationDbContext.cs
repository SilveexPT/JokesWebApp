using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using jOKESWEBAPP.Models;

namespace jOKESWEBAPP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<jOKESWEBAPP.Models.Jokes> Jokes { get; set; } = default!;
    }
}