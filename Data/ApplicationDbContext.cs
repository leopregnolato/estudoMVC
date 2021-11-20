using estudomvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace estudoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
