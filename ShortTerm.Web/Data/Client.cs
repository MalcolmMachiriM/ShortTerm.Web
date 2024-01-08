using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Client : BaseEntity
    {
        public string? RegNo { get; set; }
        public int ClientTypeId { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey(name: "GenderId")]
        public Gender? Gender { get; set; }
        public int GenderId { get; set; }

        [ForeignKey(name: "MaritalStatusId")]
        public MaritalStatus? MaritalStatus { get; set; }
        public int MaritalStatusId { get; set; }
        public string? CountryOfBirth { get; set; }
        public string? CountryOfResidence { get; set; }

        public string? Language { get; set; }

        public string? Religion { get; set; }
        public int? IncomeGroupId { get; set; }

        [ForeignKey(name: "HighestQualificationId")]
        public HighestQualification? HighestQualification { get; set; }
        public int HighestQualificationId { get; set; }
        public bool Active { get; set; }
        public int AddedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
        public string? NationalId { get; set; }
        public int Status { get; set; }
        public int StatusValue { get; set; }
        public bool IsAuthorized { get; set; }
    }
}
