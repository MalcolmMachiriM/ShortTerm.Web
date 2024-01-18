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
        public string FirstName { get; set; }

        [Display(Name = "Date of Registration")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Country of Residence")]
        public int? CountryOfBirth { get; set; }
        public SelectList? CountriesOfBirth { get; set; }

        [Display(Name = "Country Founded")]
        public string? CountryOfResidence { get; set; }
        public SelectList? CountriesOfResidence { get; set; }

        [Display(Name = "Contact Person Name")]
        public string? ContactPersonName { get; set; }

        [Display(Name = "Contact Person Phone Number")]
        public string? ContactPersonNumber { get; set; }

        [Display(Name = "Registration Number")]
        public string? NationalId { get; set; }
      
    }
}
