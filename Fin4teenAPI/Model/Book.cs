using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fin4teenAPI.Model
{
    public class Book
    {
        public int id_book { get; set; }
        [Key]
        public string name { get; set; }
        public string description { get; set; }
        public string urlImage { get; set; }
        public int pages { get; set; }
        public string releaseDate { get; set; }
        public string urlAmazon { get; set; }
    }
}
