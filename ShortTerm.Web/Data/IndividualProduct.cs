using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class IndividualProduct : BaseEntity
    {

        [ForeignKey("ProductGroupId")]
        public ProductGroup ProductGroup { get; set; }
        public int ProductGroupId { get; set; }
        public string Name { get; set; }
        public int ProcessTime { get; set; }
        public double Retention { get; set; }
        public double SumAssuredBasis  { get; set; }
        public bool CanBeCeded { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Description { get; set; }
        public int MaxPremiumTerm { get; set; }
        public int MinPremiumTerm { get; set; }
        public int MinSumAssured { get; set; }
        public int MaxSumAssured { get; set; }


    }
}
