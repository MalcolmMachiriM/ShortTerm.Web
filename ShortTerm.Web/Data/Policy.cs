﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Policy : BaseEntity
    {
        [Display(Name = "Application Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ApplicationDate { get; set; }

        [ForeignKey("ProductGroupId")]
        public ProductGroup? ProductGroup { get; set; }
        public int ProductGroupId { get; set; }

        [ForeignKey("IndividualProductId")]
        public IndividualProduct? IndividualProduct { get; set; }
        public int IndividualProductId { get; set; }
        public Client? Client { get; set; }
        public int ClientId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public double AnnualSalary { get; set; }
        public int PremiumTerm { get; set; }
        public int BenefitTerm { get; set; }

        [Display(Name = "Sum Assured")]
        [DataType(DataType.Currency)]
        public double SumAssured { get; set; }
        public double Premium { get; set; }
        public PaymentFrequency? PaymentFrequency { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }
        public int PaymentFrequencyId { get; set; }
        public bool? Approved { get; set; }
    }
}
