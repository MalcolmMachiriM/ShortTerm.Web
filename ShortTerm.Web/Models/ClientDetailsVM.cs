using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ClientDetailsVM
    {
        public int Id { get; set; }
        public Client? Client { get; set; }
        public int ClientTypeId { get; set; }
        public Title? Title { get; set; }
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string? Surname { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
        [Display(Name = "Gender ")]
        public int? GenderId { get; set; }

        public string? NationalId { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }

        [Display(Name = "Marital Status")]
        public int? MaritalStatusId { get; set; }
        [Display(Name = "Country of Birth")]
        public int? CountryOfBirth { get; set; }

        [Display(Name = "Country of Residence")]
        public int? CountryOfResidence { get; set; }


        [Display(Name = "Language")]
        public int? Language { get; set; }

        [Display(Name = "Religion")]
        public int? Religion { get; set; }

        [Display(Name = "Income Group")]
        public int? IncomeGroupId { get; set; }
        public IncomeTypes? IncomeGroup { get; set; }

        [ForeignKey(name: "HighestQualificationId")]
        public HighestQualification? HighestQualification { get; set; }
        public int? HighestQualificationId { get; set; }
        public bool? Active { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonNumber { get; set; }
        public int? Status { get; set; }
    }
}
