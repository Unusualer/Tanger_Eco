using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tanger_Eco.Models;
using TangerEco.Models;

namespace Tanger_Eco.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TangerEco.Models.DemandeModel>? DemandeModel { get; set; }
        public DbSet<Tanger_Eco.Models.QuestionModel>? QuestionModel { get; set; }
        }
}
