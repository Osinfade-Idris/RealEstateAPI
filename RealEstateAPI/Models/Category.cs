using System.ComponentModel.DataAnnotations;

namespace RealEstateAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name Can't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Image URL Can't be empty")]
        public string ImageUrl { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
