using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Models
{
    public class PolicyRulesVM
    {
        public int Id { get; set; }
        public List<Requirement>? Requirements { get; set; }
        public int RequirementsId { get; set; }
        public int IndividualProductId { get; set; }
        public string? ProductName { get; set; }
    }
}
