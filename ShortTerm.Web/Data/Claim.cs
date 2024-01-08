using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Claim : BaseEntity
    {
        [ForeignKey(name:"ClientId")]
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public int Product { get; set; }
        public DateTime DateSubmitted { get; set; }
        public bool? Approved { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
    }
}
