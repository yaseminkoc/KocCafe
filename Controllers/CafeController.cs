using KocCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace KocCafe.Controllers
{
    public class CafeController : Controller
    {
        // GET: Cafe
        Context db = new Context();
    public ActionResult Index()
        {
            MyViewModel d = new MyViewModel();
            d.DrinkList = db.Drinks.ToList();
            d.DrinkTypeList = db.DrinkTypes.ToList();
            d.MenuItemList = db.MenuItems.ToList();
            d.AboutItemList = db.AboutItems.ToList();
            d.SpecialItemList = db.SpecialItems.ToList();
            return View(d);
        }
    }
}