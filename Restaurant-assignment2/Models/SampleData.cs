using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Restaurant_assignment2.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Appetizer" },
                new Genre { Name = "Main Course" },
                new Genre { Name = "Desserts" },
                new Genre { Name = "Beverages" },
            };

            var food = new List<Food>
            {
                new Food { Foodname= "Spring Roll" },
                new Food { Foodname = "Mapo Tofu" },
                new Food { Foodname = "Taro Pudding" },
                new Food { Foodname = "Wanglaoji Tea" },
                new Food { Foodname = "Harbin Bear" },
            };

            new List<Album>
            {
                new Album { Title = "Generally", Genre = genres.Single(g => g.Name == "Appetizer"), Price = 8.99M, Food = food.Single(a => a.Foodname == "Spring Roll"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "SiChuan Food", Genre = genres.Single(g => g.Name == "Main Course"), Price = 8.99M, Food = food.Single(a => a.Foodname == "Mapo Tofu"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "ShangHai Snack", Genre = genres.Single(g => g.Name == "Desserts"), Price = 8.99M, Food = food.Single(a => a.Foodname == "Taro Pudding"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "China Beverages", Genre = genres.Single(g => g.Name == "Beverages"), Price = 8.99M, Food = food.Single(a => a.Foodname == "Wanglaoji Tea"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "China Beverages", Genre = genres.Single(g => g.Name == "Beverages"), Price = 8.99M, Food = food.Single(a => a.Foodname == "Harbin Bear"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
            }.ForEach(a => context.Albums.Add(a));
        }
    }
}