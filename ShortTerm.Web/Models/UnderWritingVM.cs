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
        public decimal ClientProposedValueOfAsset { get; set; }
        public int StateOfProperty { get; set; }
        public SelectList? StateOfProps { get; set; }
        public int LocationOfProperty { get; set; }
        public SelectList? LocationOfProps { get; set; }
        public int SecurityOfPropertyScore { get; set; }
        public SelectList? SecurityOfProps { get; set; }
        public int PrimaryUseOfPropertyScore { get; set; }
        public SelectList? PrimaryUseOfProps { get; set; }
        public string? AdditionalNotes { get; set; }
    }
}
