using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolidayChallenge.Models
{
    public class Present
    {
        public int Id {  get; set; }
        public enum PresentType { BigBox, SmallBox, BigBag, SmallBag, Stocking, Unwrapped }
        public string Wrapping { get; set; }
        public string Contains { get; set; }
        public List<string> Hints { get; set; }
        public int TimesShaken { get; set; }
        public bool IsWrapped { get; set; }
        public int TreeId { get; set; }
        public virtual Tree Tree { get; set; }

    }
}