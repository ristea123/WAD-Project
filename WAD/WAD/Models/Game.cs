using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Reviews { get; set; }

        public int DeveloperId { get; set; }
        public virtual Developer Developer { get; set; }
        public int ReviewrId { get; set; } 

    }
}