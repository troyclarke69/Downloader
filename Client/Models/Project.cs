using System;
using System.Collections.Generic;

namespace Client.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Platform { get; set; }
        public string Git { get; set; }
        public string Notes { get; set; }
        public string Slug { get; set; }
        public string Tag { get; set; }
        public string Image { get; set; }
        public Boolean Show { get; set; }

        public List<string> Blog { get; set; }

    }
}
