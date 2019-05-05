using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WADFinal.Models
{
    public class Developer : Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}