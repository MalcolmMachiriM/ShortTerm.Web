using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Data
{
    public class ProductGroup : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        [ForeignKey("SchemeId")]
        public Scheme Scheme { get; set; }
        public int SchemeId { get; set; }
    }
}
