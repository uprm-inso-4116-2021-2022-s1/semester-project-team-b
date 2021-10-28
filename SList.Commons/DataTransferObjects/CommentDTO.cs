using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Commons.DataTransferObjects
{
    public partial class CommentDTO
    {
        public CommentDTO()
        {
            OriginalComment = new HashSet<CommentDTO>();
        }
        public string Content { get; set; }
        public byte[] CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual RecipeDTO Recipe { get; set; }
        public virtual CommentDTO Parent { get; set; }
        public virtual ForumDTO Forum { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ICollection<CommentDTO> OriginalComment { get; set; }
    }
}
