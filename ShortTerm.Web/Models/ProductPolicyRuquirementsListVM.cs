using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ProductPolicyRuquirementsListVM
    {
        public int Id { get; set; }

        [Display(Name = "Reg No")]
        public string? RegNo { get; set; }

        [Display(Name="Product Name")]
        public IndividualProductVM? IndividualProduct { get; set; }
        public int? IndividualProductId { get; set; }

        [ForeignKey("Requirement")]
        public Requirement? Requirement { get; set; }

        [Display(Name = "Mandatory?")]
        public bool IsMandatory { get; set; }
        public string? Description { get; set; }
    }
}
