using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD.Models
{
    public class Client : Account
    {
        public int ClientId { get; set; }
        public virtual ICollection<Game> Favourites { get; set; }
    }
}