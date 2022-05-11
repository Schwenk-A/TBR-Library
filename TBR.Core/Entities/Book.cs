using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBR.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Authors { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReadingPosition { get; set; }
        public string AcessBookURLInfo { get; set; } = string.Empty;
        public string BookMediumPicture { get; set; } = string.Empty;
        public int PageCount { get; set; }

        public string Categories { get; set; } = string.Empty;

        public string ISBN { get; set; }

        public string PublishDate { get; set; }


    }
}
