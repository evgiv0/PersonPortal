using System;

namespace Models
{
    public class Comment
    {
        public string Author { get; set; }
        public string Body { get; set; }
        public long CommentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long PostId { get; set; }
    }
}
