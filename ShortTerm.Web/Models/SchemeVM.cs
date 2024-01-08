using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class SchemeVM
    {
        public int Id { get; set; }
        [Display(Name = "Reg No")]
        public string RegNo { get; set; }

        [Display(Name = "Reg Name")]
        public string RegName { get; set; }

        [Display(Name = "Tax no")]
        public string Taxno { get; set; }

        [Display(Name = "Reassurance No")]
        public string ReassuranceNo { get; set; }

        [Display(Name = "Commencement Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime CommencementDate { get; set; }

        [Display(Name = "Conversion Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime ConversionDate { get; set; }

        [Display(Name = "Rules Ammendment")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime RulesAmmendment { get; set; }

        [Display(Name = "Retention Limit")]
        public double RetentionLimit { get; set; }

        [Display(Name = "Institutional Client's Name")]
        public int InstitutionalClientsName { get; set; }
    }
}
