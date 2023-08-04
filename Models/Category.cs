using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key] // Key attribute assigns 'ID' as the primary key
        public int Id { get; set; }

        [Required] // 
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        // Accept a number between numbers specified below
        [Range(1,100)]
        public int DisplayOrder { get; set; }

    }
}
