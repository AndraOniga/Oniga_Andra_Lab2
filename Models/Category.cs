using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Oniga_Andra_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
