using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prism.Domain.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string? Name { get; set; } = "Default Name";

        public string? Description { get; set; }

        public double? Price { get; set; }

        public int? Stock { get; set; }

        public DateTime? CreatedDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}