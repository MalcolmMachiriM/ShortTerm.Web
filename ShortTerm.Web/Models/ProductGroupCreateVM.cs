using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class ProductGroupCreateVM
    {

        [Display(Name = "Product Group Name")]
        public string Name { get; set; }

        [Display(Name = "Product Group Code")]
        public string Code { get; set; }

        [Display(Name = "Product Group Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Scheme Name")]
        public int SchemeId { get; set; }

        public SelectList? Schemes { get; set; }
    }
}
