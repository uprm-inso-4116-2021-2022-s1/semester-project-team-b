using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Commons.DataTransferObjects
{
    public partial class ForumDTO
    {
        public ForumDTO()
        {
            Comments = new HashSet<CommentDTO>();
        }
        public string Name { get; set; }
        public string Content { get; set; }
        public byte[] CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
