using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KocCafe.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public string DrinkDescription { get; set; }
        public int DrinkType { get; set;}
        public double DrinkPrice { get; set; }

        public string DrinkPhotoUrl { get; set; }

    }
}