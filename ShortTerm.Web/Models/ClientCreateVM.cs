using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ClientCreateVM
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
        public int HghestQualificationId { get; set; }
        public bool Active { get; set; }
        public int AddedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int ContactPersonId { get; set; }
        public string? NationalId { get; set; }
        public int Status { get; set; }
        public int StatusValue { get; set; }
        public bool IsAuthorized { get; set; }
    }
}
