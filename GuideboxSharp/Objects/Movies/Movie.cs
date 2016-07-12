using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideboxSharp.Objects
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public int release_year { get; set; }
        public int themoviedb { get; set; }
        public string original_title { get; set; }
        public List<string> alternate_titles { get; set; }
        public string imdb { get; set; }
        public bool pre_order { get; set; }
        public bool in_theaters { get; set; }
        public string release_date { get; set; }
        public string rating { get; set; }
        public int rottentomatoes { get; set; }
        public string freebase { get; set; }
        public int wikipedia_id { get; set; }
        public string metacritic { get; set; }
        public string common_sense_media { get; set; }
        public string overview { get; set; }
        public string poster_120x171 { get; set; }
        public string poster_240x342 { get; set; }
        public string poster_400x570 { get; set; }
        public Social social { get; set; }
        public List<Genre> genres { get; set; }
        public List<Tag> tags { get; set; }
        public int duration { get; set; }
        public Trailers trailers { get; set; }
        public List<Writer> writers { get; set; }
        public List<Director> directors { get; set; }
        public List<Cast> cast { get; set; }
        public List<object> free_web_sources { get; set; }
        public List<object> free_ios_sources { get; set; }
        public List<object> free_android_sources { get; set; }
        public List<object> tv_everywhere_web_sources { get; set; }
        public List<object> tv_everywhere_ios_sources { get; set; }
        public List<object> tv_everywhere_android_sources { get; set; }
        public List<object> subscription_web_sources { get; set; }
        public List<object> subscription_ios_sources { get; set; }
        public List<object> subscription_android_sources { get; set; }
        public List<PurchaseWebSource> purchase_web_sources { get; set; }
        public List<PurchaseIosSource> purchase_ios_sources { get; set; }
        public List<PurchaseAndroidSource> purchase_android_sources { get; set; }
        public OtherSources other_sources { get; set; }
    }

    public class Facebook
    {
        public long facebook_id { get; set; }
        public string link { get; set; }
    }

    public class MovieWeb
    {
        public string type { get; set; }
        public string source { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public string embed { get; set; }
    }

    public class MovieiOS
    {
        public string type { get; set; }
        public string source { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public string embed { get; set; }
    }

    public class MovieAndroid
    {
        public string type { get; set; }
        public string source { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public string embed { get; set; }
    }

    public class Trailers
    {
        public List<MovieWeb> web { get; set; }
        public List<MovieiOS> ios { get; set; }
        public List<MovieAndroid> android { get; set; }
    }

    public class Writer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imdb { get; set; }
    }

    public class Director
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imdb { get; set; }
    }

    public class Format
    {
        public string price { get; set; }
        public string format { get; set; }
        public string type { get; set; }
        public bool pre_order { get; set; }
    }

    public class PurchaseWebSource
    {
        public string source { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public List<Format> formats { get; set; }
    }

    public class PurchaseIosSource
    {
        public string source { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public string app_name { get; set; }
        public int app_link { get; set; }
        public int app_required { get; set; }
        public string app_download_link { get; set; }
        public List<Format> formats { get; set; }
    }

    public class PurchaseAndroidSource
    {
        public string source { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public string app_name { get; set; }
        public int app_link { get; set; }
        public int app_required { get; set; }
        public string app_download_link { get; set; }
        public List<Format> formats { get; set; }
    }

    public class TvOnDemand
    {
        public string source { get; set; }
        public string source_type { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public string platform { get; set; }
        public List<Format> formats { get; set; }
    }

    public class OtherSources
    {
        public List<TvOnDemand> tv_on_demand { get; set; }
    }
}