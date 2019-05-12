using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WADFinal.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Reviews { get; set; }

        public int DeveloperId { get; set; }
        public int ReviewrId { get; set; } 

    }
}