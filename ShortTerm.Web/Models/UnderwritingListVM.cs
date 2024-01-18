using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using ShortTerm.Web.Data.SystemVariables;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class UnderwritingListVM
    {
        public int Id { get; set; }
        public Client? Client { get; set; }
        public int ClientId { get; set; }
        public Policy? Policy { get; set; }
        public int PolicyId { get; set; }
        [Display(Name = "Client Proposed Value Of Asset ")]
        [DataType(DataType.Currency)]
        public double ClientProposedValueOfAsset { get; set; }
        public int StateOfPropertyId { get; set; }
        [Display(Name = "State Of Property ")]
        public StateOfProperty? StateOfProperty { get; set; }
        public int LocationOfPropertyId { get; set; }
        [Display(Name = "Location Of Property ")]
        public LocationOfProperty? LocationOfProperty { get; set; }
        public int SecurityOfPropertyScoreId { get; set; }
        [Display(Name = "Security Of Property ")]
        public SecurityOfPropertyScore? SecurityOfPropertyScore { get; set; }
        public int PrimaryUseOfPropertyScoreId { get; set; }
        [Display(Name = "Primary Use Of Property ")]
        public PrimaryUseOfPropertyScore? PrimaryUseOfPropertyScore { get; set; }
        [Display(Name = "Additional Notes ")]
        public string? AdditionalNotes { get; set; }
        public bool? Approved { get; set; }

        [Display(Name = "Date Added")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
}
