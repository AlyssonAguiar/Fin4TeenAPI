using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fin4teenAPI.Model
{
    public class TvShow
    {
        public int id_TvShow { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string urlImage { get; set; }
        public int time { get; set; }
        public DateTime release { get; set; }
        public string urlNetflix { get; set; }
        public string urlAmazon { get; set; }
        public string urlApple { get; set; }
    }
}
