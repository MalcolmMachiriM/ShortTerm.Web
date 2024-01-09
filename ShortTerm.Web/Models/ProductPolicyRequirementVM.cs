using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ProductPolicyRequirementVM
    {
        public int Id { get; set; }
        [Display(Name ="Reg No")]
        public string? RegNo { get; set; }

        [ForeignKey("IndividualProductID")]
        public IndividualProduct? IndividualProduct { get; set; }
        public int? IndividualProductID { get; set; }
        public int? DependentTypeID { get; set; }
        [ForeignKey("RequirementID")]
        public Requirement? Requirement { get; set; }
        public int? RequirementID { get; set; }
        public bool? IsMandatory { get; set; }
        public string? Description { get; set; }
    }
}
