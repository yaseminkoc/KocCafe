using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KocCafe.Models
{
    public class Context: DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkType> DrinkTypes { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<About> AboutItems { get; set; }
        public DbSet<SpecialItem> SpecialItems { get; set; }
    }
}