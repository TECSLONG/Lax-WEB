using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opgave_5___2.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public decimal Rating { get; set; }
        public int Runtime { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string ReleaseDate { get; set; }
    }
}