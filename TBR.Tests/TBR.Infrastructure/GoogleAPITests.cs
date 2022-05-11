using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using TBR.Infrastructure.GoogleBookAPI;

namespace TBR.Tests.TBR.Infrastructure
{

    [TestFixture]
    public class GoogleAPITests
    {

        private GoogleBookAPI _googleBookAPI;
        private readonly string _testTitle = "Harry Potter";
        private readonly string _testAuthor = "Stephen King";
        private readonly string _testISBN = "0071807993";



        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _googleBookAPI = new GoogleBookAPI();
        }

        [Test]
        public async Task GetByAuthor_Given_Author_Should_ReturnVolumes()
        {
            

            var books = await _googleBookAPI.GetByAuthorAsync(_testAuthor);

            var foundBooksByTestAuthor = books.Any(b => b.VolumeInfo.Authors.Contains(_testAuthor));

            Assert.IsTrue(foundBooksByTestAuthor);
        }


        [Test]
        public async Task GetByISBN_Given_ISBN_Should_ReturnVolume()
        {
            

            var apiResult = await _googleBookAPI.GetByISBNAsync(_testISBN);

            Assert.NotNull(apiResult);

        }


        [Test]
        public async Task GetByTitle_Given_Title_Should_ReturnVolumes()
        {
            var books = await _googleBookAPI.GetByTitleAsync(_testTitle);

            var foundBooksByTestTitle = books.Any(b => b.VolumeInfo.Title.Contains(_testTitle));

            Assert.IsTrue(foundBooksByTestTitle);
        }



    }
}
