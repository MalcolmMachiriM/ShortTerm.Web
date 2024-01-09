using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class ProductPolicyRequirement : BaseEntity
    {
        public string? RegNo { get; set; }

        [ForeignKey("IndividualProductID")]
        public IndividualProduct? IndividualProduct { get; set; }
        public int? IndividualProductID { get; set; }

        [ForeignKey("RequirementID")]
        public Requirement? Requirement { get; set; }
        public int? RequirementID { get; set; }
        public bool IsMandatory { get; set; }
        public string? Description { get; set; }
        public string? AddedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
