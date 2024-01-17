using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ReasurerCreateVM
    {
        public int Id { get; set; }
        public Client? Client { get; set; }

        [Display(Name ="Client Name")]
        public int ClientId { get; set; }
        public ReassuranceType? ReassuranceType { get; set; }

        [Display(Name = "Reassurance Type")]
        public int ReassuranceTypeId { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
    }
}
