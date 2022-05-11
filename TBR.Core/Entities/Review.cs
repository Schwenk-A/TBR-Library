using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ISBN { get; set; }

        public int StarRating { get; set; }

        public string UserReview { get; set; }


    }
}
