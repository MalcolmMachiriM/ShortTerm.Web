using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ClaimsListVM
    {
        [ForeignKey(name: "ClientId")]
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public int Product { get; set; }
        public DateTime DateSubmitted { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime DateApproved { get; set; }
    }
}
