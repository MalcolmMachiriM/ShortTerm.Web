namespace ShortTerm.Web.Data
{
    public class MedicalRequirements : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Tariff { get; set; }
    }
}