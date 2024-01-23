using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class PolicyReassurance : BaseEntity
    {
        public Policy? Policy { get; set; }
        public int PolicyId { get; set; }

        public double SumAssured { get; set; }
        public double ReassuranceAmount { get; set; }

        [ForeignKey("ReassurerId")]
        public Reassurer? Reassurer { get; set; }
        public int ReassurerId { get; set; }
        public ReassuranceType? ReassuranceType { get; set; }
        public int ReassuranceTypeId { get; set; }
    }
}
