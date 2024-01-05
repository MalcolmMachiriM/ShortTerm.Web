using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Configurations.Entities;

namespace ShortTerm.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<IndividualProduct> IndividualProducts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Reassurer> Reassurers { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Scheme> Schemes { get; set; }
    }
}