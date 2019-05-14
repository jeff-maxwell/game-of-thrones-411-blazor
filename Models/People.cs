using System;
using System.Collections.Generic;

namespace game_of_thrones_411_blazor.Models
{
    public class Related
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int mentions { get; set; }
    }

    public class Pagerank
    {
        public string title { get; set; }
        public int rank { get; set; }
    }

    public class Age
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    public class People
    {
        public List<string> titles { get; set; }
//        public List<string> origin { get; set; }
//        public List<string> siblings { get; set; }
//        public List<string> spouse { get; set; }
//        public List<object> lovers { get; set; }
//        public int plod { get; set; }
//        public List<object> longevity { get; set; }
//        public int plodB { get; set; }
//        public int plodC { get; set; }
//        public List<object> longevityB { get; set; }
//        public List<object> longevityC { get; set; }
//        public List<string> culture { get; set; }
//        public List<string> religion { get; set; }
//        public List<string> allegiances { get; set; }
//        public List<object> seasons { get; set; }
//        public List<string> appearances { get; set; }
        public string _id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string image { get; set; }
//        public string gender { get; set; }
//        public bool alive { get; set; }
//        public int death { get; set; }
//        public string father { get; set; }
        public string house { get; set; }
//        public string first_seen { get; set; }
        public string actor { get; set; }
//        public List<Related> related { get; set; }
//        public DateTime createdAt { get; set; }
//        public DateTime updatedAt { get; set; }
//        public int __v { get; set; }
//        public Pagerank pagerank { get; set; }
        public Age age { get; set; }
        public string id { get; set; }
    }
}