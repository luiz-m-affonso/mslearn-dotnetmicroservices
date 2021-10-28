using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(60, ErrorMessage = "Maximum length between 3 and 60 chars")]
        [MinLength(3, ErrorMessage = "Maximum length between 3 and 60 chars")]

        public string Title { get; set; }
    }
}