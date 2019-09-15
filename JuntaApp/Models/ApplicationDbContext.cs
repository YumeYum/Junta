using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JuntaApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Junta> Juntas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}