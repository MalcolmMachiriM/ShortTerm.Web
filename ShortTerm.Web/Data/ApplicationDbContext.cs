using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Configurations.Entities;

using ShortTerm.Web.Models;

using ShortTerm.Web.Data;

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
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
                entry.Entity.DateModified = DateTime.Now;

            }
            return base.SaveChangesAsync(cancellationToken);
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
        public DbSet<Title> Titles { get; set; }
        public DbSet<HighestQualification> HighestQualifications { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<ProductLapsePeriod> ProductLapsePeriods { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<RequirementType> RequirementTypes { get; set; }
        public DbSet<ProductPolicyRequirement> ProductPolicyRequirements { get; set; }
        public DbSet<SumAssuredBasis> SumAssuredBasis { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentFrequency> PaymentFrequencies { get; set; }
        public DbSet<ReassuranceType> ReassuranceTypes { get; set; }

        public DbSet<UnderWriting> UnderWritings { get; set; }

        public DbSet<ShortTerm.Web.Data.Timegroups>? Timegroups { get; set; }
        public DbSet<ShortTerm.Web.Data.InstitutionTypes>? InstitutionTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.HumanDemographicGroups>? HumanDemographicGroups { get; set; }
        public DbSet<ShortTerm.Web.Data.PremiumPaymentFrequencies>? PremiumPaymentFrequencies { get; set; }
        public DbSet<ShortTerm.Web.Data.BusinessDecisions>? BusinessDecisions { get; set; }
        public DbSet<ShortTerm.Web.Data.RelationshipTypes>? RelationshipTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.Requirements>? Requirements_1 { get; set; }
        public DbSet<ShortTerm.Web.Data.PaymentMethods>? PaymentMethods_1 { get; set; }
        public DbSet<ShortTerm.Web.Data.InterestRateTypes>? InterestRateTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.InterestRateFrequencies>? InterestRateFrequencies { get; set; }
        public DbSet<ShortTerm.Web.Data.Banks>? Banks { get; set; }
        public DbSet<ShortTerm.Web.Data.StopOrderName>? StopOrderName { get; set; }
        public DbSet<ShortTerm.Web.Data.Countries>? Countries { get; set; }
        public DbSet<ShortTerm.Web.Data.Cities>? Cities { get; set; }
        public DbSet<ShortTerm.Web.Data.IdentificationTypes>? IdentificationTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.Languages>? Languages_1 { get; set; }
        public DbSet<ShortTerm.Web.Data.MedicalRequirements>? MedicalRequirements { get; set; }
        public DbSet<ShortTerm.Web.Data.HabitsAndInterests>? HabitsAndInterests { get; set; }
        public DbSet<ShortTerm.Web.Data.Currencies>? Currencies { get; set; }
        public DbSet<ShortTerm.Web.Data.Occupations>? Occupations { get; set; }
        public DbSet<ShortTerm.Web.Data.AddressTypes>? AddressTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.Titles>? Titles_1 { get; set; }
        public DbSet<ShortTerm.Web.Data.IncomeTypes>? IncomeTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.Qualifications>? Qualifications { get; set; }
        public DbSet<ShortTerm.Web.Data.Religions>? Religions_1 { get; set; }
        public DbSet<ShortTerm.Web.Data.AccountTypes>? AccountTypes { get; set; }
        public DbSet<ShortTerm.Web.Data.UnderwritingQuestions>? UnderwritingQuestions { get; set; }

    }
}