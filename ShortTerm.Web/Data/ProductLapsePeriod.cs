using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class ProductLapsePeriod : BaseEntity
    {
        public string? RegNo { get; set; }

        [ForeignKey("IndividualProductID")]
        public IndividualProduct? IndividualProduct { get; set; }
        public int ProductID { get; set; }
        public int LapsePeriod { get; set; }
        public int MinDurationInForce { get; set; }
        public int MaxDurationInForce { get; set; }
        public string? Description { get; set; }
        public int? AddedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
