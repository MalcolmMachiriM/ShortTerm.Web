namespace ShortTerm.Web.Data
{
    public class IdentificationTypes : BaseEntity
    {
        public string IdentificationTypeName { get; set; }
        public string Format { get; set; }
        public int MinimunRequiredLength { get; set; }
        public int MaximumRequiredLength { get; set; }
    }
}