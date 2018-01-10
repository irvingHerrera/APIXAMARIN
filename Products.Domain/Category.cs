using System.ComponentModel.DataAnnotations;

namespace Products.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public int Description { get; set; }
    }
}
