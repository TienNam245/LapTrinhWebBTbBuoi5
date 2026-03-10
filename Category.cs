using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;  
namespace DuAnDauTien.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên chủ đề không được để trống")]
        [Display(Name = "Tên chủ đề")]
        public string CategoryName { get; set; } = string.Empty; 
        public ICollection<Book> Books { get; set; } = new List<Book>();  
    }
}
