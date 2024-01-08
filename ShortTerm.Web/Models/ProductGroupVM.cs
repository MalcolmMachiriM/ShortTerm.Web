using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ProductGroupVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        [Display(Name = "Scheme Name")]

        public Scheme? Scheme { get; set; }
    }
}
