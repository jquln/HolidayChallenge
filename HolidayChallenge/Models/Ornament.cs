﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolidayChallenge.Models
{
    public class Ornament
    {
        int Id { get; set; }
        public string Description { get; set; }
        public int TreeId { get; set; }
        public virtual Tree Tree { get; set; }
    }
}