using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Client : BaseEntity
    {
        public int ClientTypeId { get; set; }
        public int? Title { get; set; }
        public string FirstName { get; set; }
        public string? Surname { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey(name: "GenderId")]
        public Gender? Gender { get; set; }
        public int? GenderId { get; set; }

        [ForeignKey(name: "MaritalStatusId")]
        public MaritalStatus? MaritalStatus { get; set; }
        public int? MaritalStatusId { get; set; }
        public Countries? Countries { get; set; }
        public int? CountryOfBirth { get; set; }
        public int? CountryOfResidence { get; set; }
        public Language? Languages { get; set; }
        public int? LanguageId { get; set; }
        public Religion? Religions { get; set; }
        public int? Religion { get; set; }
        public IncomeTypes? IncomeGroup { get; set; }
        public int? IncomeGroupId { get; set; }

        [ForeignKey(name: "HighestQualificationId")]
        public HighestQualification? HighestQualification { get; set; }
        public int? HighestQualificationId { get; set; }
        public bool? Active { get; set; }
        public int? AddedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonNumber { get; set; }
        public string? NationalId { get; set; }
        public int? Status { get; set; }
        public int? StatusValue { get; set; }
        public bool? IsAuthorized { get; set; }
    }
}
