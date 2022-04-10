﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProject_MVC.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public string Index()
        {
            return "Shop Index";
        }
        public string Product()
        {
            return "Product page";
        }
        public string nProduct(int id)
        {
            return "Product: Id = " + id.ToString();
        }
        public string nmProduct(string Type, string Colour)
        {
            return String.Format("Product Type = {0}, Colour={1}", Type, Colour);
        }
    }
}