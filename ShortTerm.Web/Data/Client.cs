using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Client : BaseEntity
    {
        public string RegNo { get; set; }
        public int ClientTypeId { get; set; }
        public int TitleId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey(name: "GenderId")]
        public Gender Gender { get; set; }
        public int GenderId { get; set; }

        [ForeignKey(name: "MaritalStatusId")]
        public MaritalStatus MaritalStatus { get; set; }
        public int MaritalStatusId { get; set; }
        public int CountryOfBirthId { get; set; }
        public int CountryOfResidenceId { get; set; }

        [ForeignKey(name: "LanguageId")]
        public Language Language { get; set; }
        public int LanguageId { get; set; }

        [ForeignKey(name: "ReligionId")]
        public Religion Religion { get; set; }
        public int ReligionId { get; set; }
        public int IncomeGroupId { get; set; }
        public int HghestQualificationId { get; set; }
        public bool Active { get; set; }
        public int AddedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int ContactPersonId { get; set; }
        public string NationalId { get; set; }
        public int Status { get; set; }
        public int StatusValue { get; set; }
        public bool IsAuthorized { get; set; }
    }
}
