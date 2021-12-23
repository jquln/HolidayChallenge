using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HolidayChallenge.Models
{
    public class TreeDbContext : DbContext
    {
        public TreeDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Tree> Trees { get; set; }
    }
}