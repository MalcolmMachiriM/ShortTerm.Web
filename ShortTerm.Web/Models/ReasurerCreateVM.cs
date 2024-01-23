using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ReasurerCreateVM
    {
        public string Name { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Display(Name = "Contact Details")]
        public string ContactDetails { get; set; }
        public string Email { get; set; }
    }
}
