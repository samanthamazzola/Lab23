using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //create 
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();
           
            ViewBag.Items = ORM.items.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewCustomer() //post
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();

            return View();
        }

        //public ActionResult RegisterNewCustomer(customer newCustomer) //add 
        //{
        //    gccoffeeshopEntities ORM = new gccoffeeshopEntities();

        //    ORM.customer.Add(newCustomer);
        //    ORM.SaveChanges();

        //    return RedirectToAction("CustomerProfile");
        //}

        //public ActionResult ItemDetails(int itemid) //this action will show the data before the update
        //{   //this action will show the data before the update
        //    gccoffeeshopEntities ORM = new gccoffeeshopEntities();

        //    //find the item
        //    item ItemToEdit = ORM.items.Find(itemid);

        //    //sent it back to view
        //    ViewBag.ItemToEdit = ItemToEdit;
        //    return View();
        //}
    }

    public class customer
    {
    }
}