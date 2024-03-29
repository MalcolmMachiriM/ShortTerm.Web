﻿using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class PolicyDetailsVM
    {
        public int Id { get; set; }
        [Display(Name = "Application Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ApplicationDate { get; set; }

        [Display(Name = "Product Group")]
        public ProductGroupVM? ProductGroup { get; set; }
        public int ProductGroupId { get; set; }

        [Display(Name ="Individual Product")]
        public IndividualProductVM? IndividualProduct { get; set; }
        public int IndividualProductId { get; set; }
        public ClientListVM? Client { get; set; }

        [Display(Name = "Client Name")]
        public int ClientId { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateCreated { get; set; }
        public int Age { get; set; }

        [Display(Name = "Annual Salary")]
        public double AnnualSalary { get; set; }

        [Display(Name = "Premium Term")]
        public int PremiumTerm { get; set; }

        [Display(Name = "Benefit Term")]
        public int BenefitTerm { get; set; }

        [Display(Name = "Sum Assured")]
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }

        [DataType(DataType.Currency)]
        public double Premium { get; set; }
        public PaymentFrequency? PaymentFrequency { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }
        public int PaymentFrequencyId { get; set; }
        public bool? Approved { get; set; }
    }
}
