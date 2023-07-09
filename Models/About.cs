using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KocCafe.Models
{
    public class About
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutPhotoUrl { get; set; }
    }
}