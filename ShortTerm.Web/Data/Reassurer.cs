using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Reassurer : BaseEntity
    {
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ReassuranceTypeId")]
        public ReassuranceType? ReassuranceType { get; set; }
        public int ReassuranceTypeId  { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
    }
}
