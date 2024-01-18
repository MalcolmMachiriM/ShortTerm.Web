using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class Reassurer : BaseEntity
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string ContactDetails { get; set; }
        public string Email { get; set; }
    }
}
