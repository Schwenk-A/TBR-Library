using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Core.Entities
{
    public class UserLibrary
    {
        public IEnumerable<Book> Library { get; set; }
        public string UserId { get; set; }

    }
}
