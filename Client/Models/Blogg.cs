using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Blogg
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Markdown { get; set; }

        public string Slug { get; set; }

        public string SanitizedHtml { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
