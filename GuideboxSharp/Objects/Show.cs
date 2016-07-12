using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideboxSharp.Objects
{
    public class Show
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<object> alternate_titles { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public int container_show { get; set; }
        public string first_aired { get; set; }
        public string network { get; set; }
        public List<Channel> channels { get; set; }
        public int runtime { get; set; }
        public List<Genre> genres { get; set; }
        public List<Tag> tags { get; set; }
        public List<Cast> cast { get; set; }
        public string overview { get; set; }
        public string air_day_of_week { get; set; }
        public string air_time { get; set; }
        public string rating { get; set; }
        public string imdb_id { get; set; }
        public int tvdb { get; set; }
        public int themoviedb { get; set; }
        public string freebase { get; set; }
        public string tv_com { get; set; }
        public string metacritic { get; set; }
        public object common_sense_media { get; set; }
        public int wikipedia_id { get; set; }
        public TVRageContainer tvrage { get; set; }
        public Social social { get; set; }
        public string fanart { get; set; }
        public string poster { get; set; }
        public string banner { get; set; }
        public string artwork_208x117 { get; set; }
        public string artwork_304x171 { get; set; }
        public string artwork_448x252 { get; set; }
        public string artwork_608x342 { get; set; }
        public string url { get; set; }
        public string development_api_key { get; set; }
    }

    public class ExternalIds
    {
        public object imdb { get; set; }
        public object wikipedia_id { get; set; }
    }

    public class FacebookContainer
    {
        public object facebook_id { get; set; }
        public object link { get; set; }
    }

    public class TwitterContainer
    {
        public object twitter_id { get; set; }
        public object link { get; set; }
    }

    public class Social
    {
        public FacebookContainer facebook { get; set; }
        public TwitterContainer twitter { get; set; }
    }

    public class LiveStream
    {
        public List<object> web { get; set; }
        public List<object> ios { get; set; }
        public List<object> android { get; set; }
    }

    public class Channel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public string channel_type { get; set; }
        public string artwork_208x117 { get; set; }
        public string artwork_304x171 { get; set; }
        public string artwork_448x252 { get; set; }
        public string artwork_608x342 { get; set; }
        public ExternalIds external_ids { get; set; }
        public Social social { get; set; }
        public LiveStream live_stream { get; set; }
        public int is_primary { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string tag { get; set; }
    }

    public class Cast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string character_name { get; set; }
    }
}