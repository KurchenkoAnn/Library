using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum Genre { fantastic, horror, comedy, western, detective, drama, melodrama, action, historic, wars }
    public class Book
    {
        public string Name { set; get; }
        public string Author {get; set; }
        public int Year { set; get; }
        public Genre Genre { get; set; }
        public string imgPath { set; get; }
        public string filePath { set; get; }

    }
}
