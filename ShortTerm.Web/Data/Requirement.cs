using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Requirement : BaseEntity
    {
        [ForeignKey("RequirementTypeID")]
        public RequirementType? RequirementType { get; set; }
        public int RequirementTypeID { get; set; }
        public string? Description { get; set; }
        public string? AddedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
