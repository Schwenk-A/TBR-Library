using GenFu;
using NUnit.Framework;
using System.Threading.Tasks;
using TBR.Core.Entities;
using TBR.Infrastructure;
using TBR.Infrastructure.Data;

namespace TBR.Tests.TBR.Infrastructure
{
    [TestFixture]
    public class BookRepoTests
    {
        private BookRepo _bookRepo { get; set; } = null!;
        public BookRepoTests()
        {
            _bookRepo = new BookRepo(new TBRDbContext(ConfigurationHelper.GetTBRDataBaseKey(),true));
        }

        [Test]
        public async Task InsertBook_Given_Book_Should_InsertBook() 
        {
            Book book = A.New<Book>();

            await _bookRepo.InsertBook(book);

            var result = await _bookRepo.GetByTitle(book.Title);

            Assert.NotNull(result);

        }


        [Test]
        public async Task GetByAuthor_Given_Author_Should_ReturnBooksByAuthor()
        {
            Book book = A.New<Book>();

            await _bookRepo.InsertBook(book);

            var result = await _bookRepo.GetByAuthor(book.Authors);

            Assert.NotNull(result);

        }

    }
}
