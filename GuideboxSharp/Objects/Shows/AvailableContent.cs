using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideboxSharp.Objects
{
    public class AvailableContent
    {
        public Results results { get; set; }
    }

    public class AllSource
    {
        public int id { get; set; }
        public string source { get; set; }
        public string display_name { get; set; }
        public string type { get; set; }
    }

    public class Episodes
    {
        public int free { get; set; }
        public int tv_everywhere { get; set; }
        public int paid { get; set; }
        public int subscription { get; set; }
        public int total { get; set; }
        public List<AllSource> all_sources { get; set; }
    }

    public class Clips
    {
        public int free { get; set; }
        public int tv_everywhere { get; set; }
        public int paid { get; set; }
        public int subscription { get; set; }
        public int total { get; set; }
        public List<AllSource> all_sources { get; set; }
    }

    public class Segments
    {
        public int free { get; set; }
        public int tv_everywhere { get; set; }
        public int paid { get; set; }
        public int subscription { get; set; }
        public int total { get; set; }
        public List<object> all_sources { get; set; }
    }

    public class Web
    {
        public Episodes episodes { get; set; }
        public Clips clips { get; set; }
        public Segments segments { get; set; }
    }

    public class iOS
    {
        public Episodes episodes { get; set; }
        public Clips clips { get; set; }
        public Segments segments { get; set; }
    }

    public class Android
    {
        public Episodes episodes { get; set; }
        public Clips clips { get; set; }
        public Segments segments { get; set; }
    }

    public class Results
    {
        public Web web { get; set; }
        public iOS ios { get; set; }
        public Android android { get; set; }
    }
}