using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant_assignment2.Models;

namespace Restaurant_assignment2.Controllers
{
    
    public class MenuController : Controller
    {

        RestaurantContext storeDB = new RestaurantContext();

        //
        // GET: /Menu/
    
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return View(genres);
        }
        //this is the actually web DOC`s way
        // GET: /Menu/Browse?genre=name
  
        public ActionResult Browse(string genre = "Main Course")
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        //this way is different with DOC on web 
        // GET: /Menu/Details/1

        public ActionResult Details(int id = 1)
        {
            var album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}