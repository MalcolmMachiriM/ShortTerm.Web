using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Policy : BaseEntity
    {
        public DateTime ApplicationDate { get; set; }

        [ForeignKey("ProductGroupId")]
        public ProductGroup ProductGroup { get; set; }
        public int ProductGroupId { get; set; }
        public int Product { get; set; }
        public int ClientId { get; set; }
        public int FirstName { get; set; }
        public int Surname { get; set; }
        public int NationalID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public double AnnualSalary { get; set; }
        public int PremiumTerm { get; set; }
        public double SumAssured { get; set; }
        public double Premium { get; set; }
        public double PremiumPaymentMethod { get; set; }
        public double PremiumPaymentFrequency { get; set; }
    }
}
