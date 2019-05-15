using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD.Models
{
    public class Reviewer : Account
    {
        public int ReviewerId { get; set; }
        public virtual ICollection<Game> ReviewedGames { get; set; }
    }
}