using System;
using System.Collections.Generic;

namespace Models
{
    public class Post
    {
        public string Body { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Header { get; set; }
        public long PostId { get; set; }
        public List<Tag> Tags { get; set; }
    }
}