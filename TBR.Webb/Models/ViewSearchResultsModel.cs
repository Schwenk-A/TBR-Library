using TBR.Core.Entities;

namespace TBR.Webb.Models
{
    public class ViewSearchResultsModel : IndexModel
    {
        public IEnumerable<Book> Books { get; set; } = Enumerable.Empty<Book>();

        public ViewSearchResultsModel(IEnumerable<Book> books)
        {
            Books = books;
        }
    }
}
