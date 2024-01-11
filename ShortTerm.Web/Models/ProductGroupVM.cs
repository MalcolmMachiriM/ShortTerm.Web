using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ProductGroupVM
    {
        public int Id { get; set; }

        [Display(Name = "Group Name")]
        public string Name { get; set; }

        [Display(Name = "Group Code")]
        public string Code { get; set; }

        [Display(Name = "Group Description")]
        public string Description { get; set; }

        [Display(Name = "Scheme Name")]
        public SchemeListVM? Scheme { get; set; }
    }
}
