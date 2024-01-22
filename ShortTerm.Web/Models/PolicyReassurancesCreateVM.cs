using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    [BindProperties]
    public class PolicyReassurancesCreateVM
    {
        public Policy? Policy { get; set; }
        [Key]
        public int PolicyID { get; set; }
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }

        [DataType(DataType.Currency)]
        public double Retention { get; set; }

        [Display(Name = "Reassurance Amount")]
        [DataType(DataType.Currency)]
        public double ReassuranceAmount { get; set; }
        public SelectList? Reassurer { get; set; }
        [Display(Name ="Reasurer")]
        public int ReasurerId { get; set; }
        public SelectList? ReassuranceType { get; set; }
        [Display(Name = "Reassurance Type ")]
        public int ReassuranceTypeId { get; set; }
    }
}
