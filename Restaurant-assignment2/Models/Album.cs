using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_assignment2.Models
{
    public class Album
    {
        /// <summary>
        /// one is the empty constructor.
        /// </summary>
        public Album()
        {

        }
        /// <summary>
        /// this one constructor takes the parameter called title.
        /// </summary>
        /// <param name="title"></param>
        public Album(string Title)
        {
            this.Title = Title;
        }

        //Album class Title
        //need name of class`s ID ( the name same with class. )
        public virtual int AlbumId{get; set;}
        public virtual int GenreId { get; set; }
        public virtual int FoodId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Food Food { get; set; }
    }
}