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

        [Display(Name = "Product ")]
        public int ProductId { get; set; }
        public int ClientId { get; set; }

        [Display(Name = "Client Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Client Surname")]
        public string? Surname { get; set; }

        [Display(Name = "National ID No")]
        public string? NationalID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public double AnnualSalary { get; set; }
        public int PremiumTerm { get; set; }
        public double SumAssured { get; set; }
        public double Premium { get; set; }
        public double PremiumPaymentMethod { get; set; }
        public double PremiumPaymentFrequency { get; set; }
    }
}
