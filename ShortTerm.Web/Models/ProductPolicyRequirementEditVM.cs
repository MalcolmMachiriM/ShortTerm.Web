using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class ProductPolicyRequirementEditVM
    {
        public int Id { get; set; }
        [Display(Name = "Reg No")]
        public string? RegNo { get; set; }
        public SelectList? IndividualProduct { get; set; }

        [Display(Name = "Individual Product")]
        public int? IndividualProductID { get; set; }

        [Display(Name = "Requirement")]
        public int? RequirementID { get; set; }
        public SelectList? Requirements { get; set; }

        [Display(Name = "Is It Mandatory?")]
        public bool IsMandatory { get; set; }
        public string? Description { get; set; }
    }
}
