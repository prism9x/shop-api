using System.ComponentModel.DataAnnotations;

namespace Prism.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; } = "Default Name";

        [StringLength(1000)]
        public string? Description { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}