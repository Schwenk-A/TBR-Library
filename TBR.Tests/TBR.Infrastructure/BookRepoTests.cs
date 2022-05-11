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
        public void InsertBook_Given_Book_Should_InsertBook() 
        {
            Book book = A.New<Book>();

             _bookRepo.InsertBook(book);

            var result =  _bookRepo.GetByTitle(book.Title);

            Assert.NotNull(result);

        }


        //public Task<Book> GetByISBN(string ISBN)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
