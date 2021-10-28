using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace RestAPI.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(60, ErrorMessage = "Maximum length between 3 and 60 chars")]
        [MinLength(3, ErrorMessage = "Maximum length between 3 and 60 chars")]

        public string Title { get; set; }

        [MaxLength(60, ErrorMessage = "Maximum length between 3 and 60 chars")]

         public string Description { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than zero")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than zero")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}