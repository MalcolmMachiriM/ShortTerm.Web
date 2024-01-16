using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class PolicyCreateVM
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }

        [Display(Name ="Product Group")]
        public int ProductGroupId { get; set; }

        [Display(Name ="Individual Product")]
        public int IndividualGroupId { get; set; }
        public SelectList? Groups { get; set; }

        [Display(Name = "Product ")]
        public int IndividualProductId { get; set; }
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

        [Display(Name = "Premium Term (In Months)")]
        public int PremiumTerm { get; set; }

        [Display(Name = "Sum Assured")]
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }

        [Display(Name = "Premium")]
        [DataType(DataType.Currency)]
        public double Premium { get; set; }

        [Display(Name = "Premium Payment Method ")]
        public int PaymentMethodId { get; set; }
        public SelectList? PaymentMethod { get; set; }

        [Display(Name = "Premium Payment Frequency")]
        public int PaymentFrequencyId { get; set; }
        public SelectList? PaymentFrequency { get; set; }

        [Display(Name = "Benefit Term (In Months)")]
        public int BenefitTerm { get; set; }
    }
}
