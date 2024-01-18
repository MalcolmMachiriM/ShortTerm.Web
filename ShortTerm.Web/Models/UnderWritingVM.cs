using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class UnderWritingVM
    {
        public Client? Client { get; set; }
        public int ClientId { get; set; }
        public Policy? Policy { get; set; }

        [Display(Name ="Policy ")]
        public int PolicyId { get; set; }
        [Display(Name = "Client Proposed Value Of Asset ")]
        public decimal ClientProposedValueOfAsset { get; set; }
        [Display(Name = "State Of Property ")]

        public int StateOfPropertyId { get; set; }
        public SelectList? StateOfProps { get; set; }
        [Display(Name = "Location Of Property ")]

        public int LocationOfPropertyId { get; set; }
        public SelectList? LocationOfProps { get; set; }
        [Display(Name = "Security Of Property ")]

        public int SecurityOfPropertyScoreId { get; set; }
        public SelectList? SecurityOfProps { get; set; }
        [Display(Name = "Primary Use Of Property ")]

        public int PrimaryUseOfPropertyScoreId { get; set; }
        public SelectList? PrimaryUseOfProps { get; set; }
        [Display(Name = "AdditionalNotes ")]

        public string? AdditionalNotes { get; set; }
    }
}
