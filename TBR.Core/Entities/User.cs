using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Core.Entities
{
    public class User
    {


        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public IEnumerable<Book> Library { get; set; }

        public string Email { get; set; }


    }
}
}
