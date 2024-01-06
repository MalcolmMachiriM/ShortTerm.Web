using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class ClientListVM
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Status { get; set; }
    }
}
