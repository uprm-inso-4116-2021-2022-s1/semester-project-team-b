using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Forum
    {
        public Forum()
        {
            CommentPosts = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }
        public int? CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Comment CommentIdNavigation { get; set; }
        public virtual ICollection<Comment> CommentPosts { get; set; }
    }
}
