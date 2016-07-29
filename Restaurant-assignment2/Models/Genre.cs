using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_assignment2.Models
{
    public class Genre
    {
        public Genre()
        {

        }

        public Genre(string Name)
        {
            this.Name = Name;
        }
        //Genre class Name

        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}