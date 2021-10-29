using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Commons.DataTransferObjects
{
    public partial class CommentDTO
    {
        public CommentDTO()
        {
        }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public RecipeDTO Recipe { get; set; }
        public CommentDTO Parent { get; set; }
        public ForumDTO Forum { get; set; }
        public UserDTO User { get; set; }
        public ICollection<CommentDTO> OriginalComment { get; set; }
    }
}
