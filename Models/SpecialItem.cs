using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KocCafe.Models
{
    public class SpecialItem
    {
        public int SpecialItemId { get; set; }
        public string SpecialItemTitle { get; set; }
        public string SpecialItemDescription { get; set; }
        public string SpecialItemPhotoUrl { get; set; }
    }
}