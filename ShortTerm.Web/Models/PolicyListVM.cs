using Microsoft.AspNetCore.Mvc.Rendering;
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
        public Client? Client { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }

        [Display(Name = "Premium Term")]
        public int PremiumTerm { get; set; }

        [Display(Name = "Sum Assured")]
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }

        [DataType(DataType.Currency)]
        public double Premium { get; set; }

        [Display(Name = "Payment Method")]
        public int PremiumPaymentMethod { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }

        [Display(Name = "Payment Frequency")]
        public int PremiumPaymentFrequency { get; set; }
        public PaymentFrequency? PaymentFrequency { get; set; }

        public IndividualProduct? IndividualProduct { get; set; }
        [Display(Name = "Individual Product")]
        public int IndividualProductId { get; set; }
    }
}
