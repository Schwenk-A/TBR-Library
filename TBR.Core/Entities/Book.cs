using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBR.Core.Entities
{
    public class Book
    {

        public IEnumerable<string> Authors { get; set; } = Enumerable.Empty<string>();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReadingPosition { get; set; }
        public string AcessBookURLInfo { get; set; } = string.Empty;
        public string BookMediumPicture { get; set; } = string.Empty;
        public int PageCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> ISBN { get; set; }

        public string PublishDate { get; set; }


    }
}
