using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class PolicyReassurancesCreateVM
    {
        public int PolicyId { get; set; }
        public double SumAssured { get; set; }
        public SelectList? Reassurer { get; set; }
        [Display(Name ="Reasurer")]
        public int ReasurerId { get; set; }
        public SelectList? ReassuranceType { get; set; }
        [Display(Name = "Reassurance Type ")]
        public int ReassuranceTypeId { get; set; }
    }
}
