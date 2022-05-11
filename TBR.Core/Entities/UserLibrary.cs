using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TBR.Core.Entities
{
    public class UserLibrary
    {
        public virtual Book Book { get; set; }

        public virtual User User { get; set; }

        public virtual Review Review { get; set; }

        [ForeignKey("User")] 
        public int UserId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public int Id { get; set; }
        
    }
}
