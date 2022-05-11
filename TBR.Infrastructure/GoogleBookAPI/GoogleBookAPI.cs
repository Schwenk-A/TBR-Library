using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TBR.Infrastructure.GoogleBookAPI
{
    public class GoogleBookAPI : IGoogleBookAPI
    {
        private BooksService BookService { get; set; }
        public GoogleBookAPI()
        {
            BookService = new BooksService(
                new BaseClientService.Initializer
                {
                    ApplicationName = "ISBNBookSearch",
                    ApiKey = ConfigurationHelper.GetGoogleApiKey(),
                }
            );
        }

        public async Task<Volume> GetByISBNAsync(string isbn)
        {            
            var result = await BookService.Volumes.List(isbn).ExecuteAsync();

            return result.Items.FirstOrDefault();
        }

        public async Task<IEnumerable<Volume>> GetByAuthorAsync(string authors)
        {
            var result = await BookService.Volumes.List(authors).ExecuteAsync();

            return result.Items;
        }

        public async Task<IEnumerable <Volume>> GetByTitleAsync(string title)
        {
            var result = await BookService.Volumes.List(title).ExecuteAsync();

            return result.Items;
        }
    }
}
