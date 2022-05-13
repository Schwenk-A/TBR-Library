using Microsoft.AspNetCore.Mvc;
using TBR.Core.Entities;
using TBR.Infrastructure.GoogleBookAPI;
using TBR.Webb.Models;
using static TBR.Infrastructure.GoogleBookAPI.VolumeExtensions;

namespace TBR.Webb.Controllers
{
    public class BookController : Controller
    {

        private readonly IGoogleBookAPI _googleBookAPI;
        public BookController(IGoogleBookAPI googleBookAPI)
        {
            _googleBookAPI = googleBookAPI;
        }
        public async Task< IActionResult> GetByTitle(string title)
        {
            var books = (await _googleBookAPI.GetByTitleAsync(title)).ConvertToBooks();

            return View("ViewSearchResults", books);
        }
    }
}
