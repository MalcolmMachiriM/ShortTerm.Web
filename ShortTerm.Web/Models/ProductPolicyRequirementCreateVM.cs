using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ProductPolicyRequirementCreateVM
    {

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
