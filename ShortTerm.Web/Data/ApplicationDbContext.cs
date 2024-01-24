using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Configurations.Entities;

using ShortTerm.Web.Models;

using ShortTerm.Web.Data;
using ShortTerm.Web.Data.SystemVariables;

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

        public DbSet<Timegroups>? Timegroups { get; set; }
        public DbSet<InstitutionTypes>? InstitutionTypes { get; set; }
        public DbSet<HumanDemographicGroups>? HumanDemographicGroups { get; set; }
        public DbSet<PremiumPaymentFrequencies>? PremiumPaymentFrequencies { get; set; }
        public DbSet<BusinessDecisions>? BusinessDecisions { get; set; }
        public DbSet<RelationshipTypes>? RelationshipTypes { get; set; }
        public DbSet<Requirements>? Requirements_1 { get; set; }
        public DbSet<PaymentMethods>? PaymentMethods_1 { get; set; }
        public DbSet<InterestRateTypes>? InterestRateTypes { get; set; }
        public DbSet<InterestRateFrequencies>? InterestRateFrequencies { get; set; }
        public DbSet<Banks>? Banks { get; set; }
        public DbSet<StopOrderName>? StopOrderName { get; set; }
        public DbSet<Countries>? Countries { get; set; }
        public DbSet<Cities>? Cities { get; set; }
        public DbSet<IdentificationTypes>? IdentificationTypes { get; set; }
        public DbSet<Languages>? Languages_1 { get; set; }
        public DbSet<MedicalRequirements>? MedicalRequirements { get; set; }
        public DbSet<HabitsAndInterests>? HabitsAndInterests { get; set; }
        public DbSet<Currencies>? Currencies { get; set; }
        public DbSet<Occupations>? Occupations { get; set; }
        public DbSet<AddressTypes>? AddressTypes { get; set; }
        public DbSet<Titles>? Titles_1 { get; set; }
        public DbSet<IncomeTypes>? IncomeTypes { get; set; }
        public DbSet<Qualifications>? Qualifications { get; set; }
        public DbSet<Religions>? Religions_1 { get; set; }
        public DbSet<AccountTypes>? AccountTypes { get; set; }
        public DbSet<UnderwritingQuestions>? UnderwritingQuestions { get; set; }
        public DbSet<StateOfProperty>? StateOfProperty { get; set; }
        public DbSet<LocationOfProperty>? LocationOfProperty { get; set; }
        public DbSet<SecurityOfPropertyScore>? SecurityOfPropertyScore { get; set; }
        public DbSet<PrimaryUseOfPropertyScore>? PrimaryUseOfPropertyScore { get; set; }
        public DbSet<PolicyReassurance> PolicyReassurances { get; set; }
        public DbSet<PremiumPayment> PremiumPayments { get; set; }

    }
}