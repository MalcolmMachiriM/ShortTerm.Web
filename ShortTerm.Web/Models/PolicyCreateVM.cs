using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class PolicyCreateVM
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }

        [Display(Name ="Product Group")]
        public int ProductGroupId { get; set; }
        public SelectList? Groups { get; set; }

        [Display(Name = "Product ")]
        public int ProductId { get; set; }
        public SelectList? Products { get; set; }
        [Display(Name ="Client")]
        public int ClientId { get; set; }
        public SelectList? Clients { get; set; }

        [Display(Name = "Client Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Client Surname")]
        public string? Surname { get; set; }

        [Display(Name = "National ID No")]
        public string? NationalID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Display(Name ="Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        [Display(Name = "Annual Salary")]
        [DataType(DataType.Currency)]
        public double AnnualSalary { get; set; }

        [Display(Name = "Premium Term")]
        public int PremiumTerm { get; set; }

        [Display(Name = "Sum Assured")]
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }

        [Display(Name = "Premium")]
        [DataType(DataType.Currency)]
        public double Premium { get; set; }

        [Display(Name = "Premium Payment Method ")]
        public int PremiumPaymentMethod { get; set; }
        public SelectList? PaymentMethod { get; set; }

        [Display(Name = "Premium Payment Frequency")]
        public int PremiumPaymentFrequency { get; set; }
        public SelectList? PaymentFrequency { get; set; }
    }
}
