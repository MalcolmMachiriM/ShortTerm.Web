using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class IndividualProductVM
    {
        public int Id { get; set; }

        [Display(Name="Product Group")]
        public ProductGroup ProductGroup { get; set; }
        public string Name { get; set; }

        [Display(Name = "Process Time")]
        public int ProcessTime { get; set; }
        public double Retention { get; set; }

        [Display(Name = "Sum Assured Basis")]
        public double SumAssuredBasis { get; set; }

        [Display(Name = "Can It Be Ceded?")]
        public bool CanBeCeded { get; set; }

        [Display(Name = "Effective Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime EffectiveDate { get; set; }
        public string Description { get; set; }

        [Display(Name = "MaxPremium Term")]
        public int MaxPremiumTerm { get; set; }

        [Display(Name = "Minimum Premium Term")]
        public int MinPremiumTerm { get; set; }

        [Display(Name = "Minimum Sum Assured")]
        public int MinSumAssured { get; set; }

        [Display(Name = "Maximum Sum Assured")]
        public int MaxSumAssured { get; set; }
    }
}
