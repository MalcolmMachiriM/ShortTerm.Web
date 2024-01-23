using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class PolicyReassuranceListVM
    {
        public int Id { get; set; }
        public Policy? Policy { get; set; }
        [Display(Name ="Policy Holder")]
        public int PolicyId { get; set; }
        [Display(Name = "Sum Assured")]
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }
        [Display(Name = "Reassurance Amount")]
        [DataType(DataType.Currency)]
        public double ReassuranceAmount { get; set; }
        [Display(Name = "Retention Limit")]
        [DataType(DataType.Currency)]
        public double RetentionLimit { get; set; }
        public Reassurer? Reassurer { get; set; }
        [Display(Name = "Reassurer")]
        public int ReassurerId { get; set; }
        public ReassuranceType? ReassuranceType { get; set; }

        [Display(Name = "Reassurance Type")]
        public int ReassuranceTypeId { get; set; }
        [Display(Name = "Date Created")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0;yyyy-MM-dd}")]
        public DateTime DateCreated { get; set; }
    }
}
