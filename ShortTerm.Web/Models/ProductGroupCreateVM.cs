using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace ShortTerm.Web.Models
{
    public class ProductGroupCreateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        [Display(Name = "Scheme Name")]

        public SelectList? SchemeId { get; set; }
    }
}
