using ShortTerm.Web.Data.SystemVariables;
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
        public StateOfProperty? StateOfProperty { get; set; }
        public int StateOfPropertyId { get; set; }
        public LocationOfProperty? LocationOfProperty { get; set; }
        public int LocationOfPropertyId { get; set; }
        public SecurityOfPropertyScore? SecurityOfPropertyScore { get; set; }
        public int SecurityOfPropertyScoreId { get; set; }
        public PrimaryUseOfPropertyScore? PrimaryUseOfPropertyScore { get; set; }
        public int PrimaryUseOfPropertyScoreId { get; set; }
        public string? AdditionalNotes { get; set; }
        public bool? Approved { get; set; }
    }
}
