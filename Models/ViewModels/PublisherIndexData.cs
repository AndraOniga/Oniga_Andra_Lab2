using Oniga_Andra_Lab2.Models;

namespace Oniga_Andra_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
