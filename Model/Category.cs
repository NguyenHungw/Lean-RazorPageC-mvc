using System.ComponentModel.DataAnnotations;

namespace AbbWeb_MVC.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required] // bat buoc phai nhap ko đc rỗng
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(10, 1000,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int DisplayOrder { get; set; }
    }
}
