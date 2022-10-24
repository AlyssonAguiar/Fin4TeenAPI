using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fin4teenAPI.Model
{
    public class Movie
    {
        public int id_movie { get; set; }
        [Key]
        public string name { get; set; }
        public string description { get; set; }
        public string urlImage { get; set; }
        public int time { get; set; }
        public string releaseDate { get; set; }
        public string urlNetflix { get; set; }
        public string urlAmazon { get; set; }
        public string urlApple { get; set; }
    }
}
