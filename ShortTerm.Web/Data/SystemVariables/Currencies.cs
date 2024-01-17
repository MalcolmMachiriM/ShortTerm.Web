namespace ShortTerm.Web.Data
{
    public class Currencies : BaseEntity
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
    }
}