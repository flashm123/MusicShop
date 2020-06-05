using System;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Constants;
using MusicShop.Models;

namespace MusicShop.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(int id)
        {
            var model = new CategoryModel() 
            { 
                Name = Enum.GetName(typeof(CategoryParameters.CategoryNumber), id) 
            };

            return View(model);
        }
    }
}