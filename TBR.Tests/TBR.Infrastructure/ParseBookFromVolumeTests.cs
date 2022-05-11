using Google.Apis.Books.v1.Data;
using NUnit.Framework;
using GenFu;
using TBR.Infrastructure.GoogleBookAPI;
using System.Collections;
using System.Collections.Generic;
using TBR.Infrastructure;
using System.Threading.Tasks;
using System.Linq;

namespace TBR.Tests.TBR.Infrastructure
{
    [TestFixture]
    public class ParseBookFromVolumeTests
    {

        public Volume _testVolume { get; set; } = new Volume();

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _testVolume = await new GoogleBookAPI().GetByISBNAsync("978-1-60309-025-4");
        }

        [Test]
        public void ConvertToBook_ConvertsTitleSuccessfully()
        {
            var book = _testVolume.ConvertToBook();
            Assert.AreEqual(_testVolume.VolumeInfo.Title, book.Title);
        }

        [Test]
        public void ConvertToBook_ConvertsAuthorsSuccessfully()
        {
            var book = _testVolume.ConvertToBook();
            Assert.AreEqual(_testVolume.VolumeInfo.Authors, book.Authors);
        }

        [Test]
        public void ConvertToBook_ConvertsBookMediumPictureSuccessfully()
        {
            var book = _testVolume.ConvertToBook();
            Assert.AreEqual(_testVolume.VolumeInfo.ImageLinks.Medium, book.BookMediumPicture);
        }


        [Test]
        public void ConvertToBook_ConvertsPublishedDateSuccessfully()
        {
            var book = _testVolume.ConvertToBook();
            Assert.AreEqual(_testVolume.VolumeInfo.PublishedDate, book.PublishDate);
        }

        [Test]
        public void ConvertToBook_ConvertsDiscriptionSuccessfully()
        {
            var book = _testVolume.ConvertToBook();
            Assert.AreEqual(_testVolume.VolumeInfo.Description, book.Description);
        }

        [Test]
        public void ConvertToBook_ConvertsISBNSuccessfully()
        {
            var book = _testVolume.ConvertToBook();
            Assert.AreEqual(_testVolume.VolumeInfo.IndustryIdentifiers.Select(isbn => isbn.Identifier), book.ISBN);
        }
    }
}
