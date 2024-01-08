namespace ShortTerm.Web.Data
{
    public class RequirementType : BaseEntity
    {
        public string? Description { get; set; }
        public string? AddedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
