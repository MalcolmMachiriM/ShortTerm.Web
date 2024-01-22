namespace ShortTerm.Web.Data
{
    public class PolicyReassurance : BaseEntity
    {
        public int PolicyId { get; set; }
        public double SumAssured { get; set; }
        public double ReassuranceAmount { get; set; }
        public Reassurer? Reassurer { get; set; }
        public int ReasurerId { get; set; }
        public ReassuranceType? ReassuranceType { get; set; }
        public int ReassuranceTypeId { get; set; }
    }
}
