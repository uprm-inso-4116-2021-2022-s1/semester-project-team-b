using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Comment
    {
        public Comment()
        {
            InverseParent = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public int? PostId { get; set; }
        public int? ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual Forum IdNavigation { get; set; }
        public virtual Comment Parent { get; set; }
        public virtual Forum Post { get; set; }
        public virtual Recipe PostNavigation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> InverseParent { get; set; }
    }
}
