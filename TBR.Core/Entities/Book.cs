using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Core.Entities
{
    public class Book
    {

        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int ReadingPosition { get; set; }
        public string BookUrl { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int PageCount { get; set; }

        public IEnumerable<string> Subject { get; set; } = Enumerable.Empty<string>();

        public int ISBN { get; set; }

        public int PublishedYear { get; set; }


    }
}
