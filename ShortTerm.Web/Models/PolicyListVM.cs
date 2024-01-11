using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class PolicyListVM
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }

        [Display(Name ="Product Group")]
        public ProductGroupVM? ProductGroup { get; set; }
        public int Product { get; set; }

        [Display(Name = "Client Name")]
        public int FirstName { get; set; }
        public int Surname { get; set; }
        public int PremiumTerm { get; set; }

        [Display(Name = "Sum Assured")]
        public double SumAssured { get; set; }
        public double Premium { get; set; }

        [Display(Name = "Payment Method")]
        public double PremiumPaymentMethod { get; set; }

        [Display(Name = "Payment Frequency")]
        public double PremiumPaymentFrequency { get; set; }
    }
}
