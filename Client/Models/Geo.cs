using System;

namespace Client.Models
{
    public class Geo
    {
        //public string Id { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string city { get; set; }
        public string postal { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string iPv4 { get; set; }
        public string state { get; set; }

        public DateTime timestamp { get; set; } = DateTime.Now;
        public string url { get; set; } = "Home";
    }
}
