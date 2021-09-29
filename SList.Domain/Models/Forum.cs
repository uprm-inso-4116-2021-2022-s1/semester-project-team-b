using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Forum
    {
        public Forum()
        {
            Comments = new HashSet<Comment>();
        }
        public string Title { get; set; }
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
