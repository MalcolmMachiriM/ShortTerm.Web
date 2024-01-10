using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Scheme :BaseEntity
    {
        public string RegNo { get; set; }
        public string RegName { get; set; }
        public string Taxno { get; set; }
        public string ReassuranceNo { get; set; }
        public DateTime CommencementDate { get; set; }
        public DateTime ConversionDate { get; set; }
        public DateTime RulesAmmendment { get; set; }
        public double RetentionLimit { get; set; }
        public int InstitutionalClientsName { get; set; }

        //[ForeignKey("ClientId")]
        //public Client? Clients { get; set; }
        //public int ClientId { get; set; }
    }
}
