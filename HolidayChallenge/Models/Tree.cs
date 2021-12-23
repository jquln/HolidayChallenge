using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolidayChallenge.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual List<Present> Presents { get; set; }
        public virtual List<Ornament> Ornaments { get; set; }

    }
}