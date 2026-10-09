using System.ComponentModel.DataAnnotations;

namespace ProductMvc.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }
    }
}