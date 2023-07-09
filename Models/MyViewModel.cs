using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KocCafe.Models
{
    public class MyViewModel
    {
    
            public List<Drink> DrinkList { get; set; }
            public List<DrinkType> DrinkTypeList { get; set; }
            public List<MenuItem> MenuItemList { get; set; }
            public List<About> AboutItemList { get; set; }

            public List<SpecialItem>SpecialItemList { get; set; }
        public MyViewModel()
                {
                    this.DrinkList = new List<Drink>();
                    this.DrinkTypeList = new List<DrinkType>();
                    this.MenuItemList = new List<MenuItem>();
                    this.AboutItemList = new List<About>();
                    this.SpecialItemList = new List<SpecialItem>();
                }
            }
 
}