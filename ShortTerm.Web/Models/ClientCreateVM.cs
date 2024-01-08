using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ClientCreateVM
    {
        public string? RegNo { get; set; }
        public SelectList? ClientTypeId { get; set; }
        public SelectList? TitleId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string Surname { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public SelectList? GenderId { get; set; }

        [Display(Name = "Marital Status")]
        public SelectList? MaritalStatusId { get; set; }

        [Display(Name = "Country of Birth")]
        public string? CountryOfBirth { get; set; }

        [Display(Name = "Country of Residence")]
        public string? CountryOfResidence { get; set; }

        public string? Language { get; set; }

        public string? Religion { get; set; }

        [Display(Name = "Income Group")]
        public int? IncomeGroupId { get; set; }

        [Display(Name = "Highest Qualification")]
        public SelectList? HighestQualificationId { get; set; }

        [Display(Name = "Contact Person Name")]
        public string? ContactPersonName { get; set; }

        [Display(Name = "Contact Person Phone Number")]
        public string? ContactPersonNumber { get; set; }

        [Display(Name = "National Identity Number")]
        public string? NationalId { get; set; }
      
    }
}
