using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTerm.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Web.Models
{
    public class ClaimVM
    {
        [ForeignKey(name: "Client ")]
        public SelectList? Client { get; set; }
        public int Product { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
