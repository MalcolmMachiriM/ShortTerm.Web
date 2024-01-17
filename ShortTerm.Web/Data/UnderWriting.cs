using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class UnderWriting : BaseEntity
    {
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("PolicyId")]
        public Policy? Policy { get; set; }
        public int PolicyId { get; set; }
        public double ClientProposedValueOfAsset { get; set; }
        public int StateOfProperty { get; set; }
        public int LocationOfProperty { get; set; }
        public int SecurityOfPropertyScore { get; set; }
        public int PrimaryUseOfPropertyScore { get; set; }
        public string? AdditionalNotes { get; set; }
        public bool? Approved { get; set; }
    }
}
