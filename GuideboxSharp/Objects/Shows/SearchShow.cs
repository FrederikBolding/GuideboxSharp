using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideboxSharp.Objects
{
    public class SearchShow
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<object> alternate_titles { get; set; }
        public int container_show { get; set; }
        public string first_aired { get; set; }
        public string imdb_id { get; set; }
        public int tvdb { get; set; }
        public int themoviedb { get; set; }
        public string freebase { get; set; }
        public int wikipedia_id { get; set; }
        public TVRageContainer tvrage { get; set; }
        public string artwork_208x117 { get; set; }
        public string artwork_304x171 { get; set; }
        public string artwork_448x252 { get; set; }
        public string artwork_608x342 { get; set; }
        public string development_api_key { get; set; }
    }

    public class TVRageContainer
    {
        public int tvrage_id { get; set; }
        public string link { get; set; }
    }
}