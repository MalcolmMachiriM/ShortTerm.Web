using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class ReasurerListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Display(Name = "Contact Details")]
        public string ContactDetails { get; set; }
        public string Email { get; set; }
        [Display(Name ="Date Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateCreated { get; set; }
    }
}
