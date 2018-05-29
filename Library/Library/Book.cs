using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Name { set; get; }
        public string Author { set; get; }
        public int Year { set; get; }
        enum Genre { fantastic, horror, comedy, western, detective, drama, melodrama, action, historic, wars }
        public string imgPath { set; get; }
        public string filePath { set; get; }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
