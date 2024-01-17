using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class InstitutionalClientCreateVM
    {
        public SelectList? ClientType { get; set; }

        [Display(Name = "Client Type")]
        public int? ClientTypeId { get; set; }

        [Display(Name = "Title")]
        public int? TitleId { get; set; }
        public SelectList? Titles { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? Surname { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public int? GenderId { get; set; }
        public SelectList? Genders { get; set; }

        [Display(Name = "Marital Status")]
        public int? MaritalStatusId { get; set; }
        public SelectList? MaritalStatus { get; set; }

        [Display(Name = "Country of Birth")]
        public int? CountryOfBirth { get; set; }
        public SelectList? CountriesOfBirth { get; set; }

        [Display(Name = "Country of Residence")]
        public string? CountryOfResidence { get; set; }
        public SelectList? CountriesOfResidence { get; set; }

        public int? Language { get; set; }
        public SelectList? Languages { get; set; }

        public int? Religion { get; set; }
        public SelectList? Religions { get; set; }

        [Display(Name = "Income Group")]
        public int? IncomeGroupId { get; set; }
        public SelectList? IncomeGroups { get; set; }

        [Display(Name = "Highest Qualification")]
        public int? HighestQualificationId { get; set; }
        public SelectList? HighestQualification { get; set; }

        [Display(Name = "Contact Person Name")]
        public string? ContactPersonName { get; set; }

        [Display(Name = "Contact Person Phone Number")]
        public string? ContactPersonNumber { get; set; }

        [Display(Name = "National Identity Number")]
        public string? NationalId { get; set; }
      
    }
}
