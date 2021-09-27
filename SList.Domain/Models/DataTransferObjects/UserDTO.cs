using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models.DataTransferObjects
{
    public class UserDTO
    {
        public UserDTO()
        {
            Comments = new HashSet<CommentDTO>();
            Forums = new HashSet<ForumDTO>();
            Pantries = new HashSet<PantryDTO>();
            Recipes = new HashSet<RecipeDTO>();
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; internal set; }
        public virtual ICollection<CommentDTO> Comments { get; set; }
        public virtual ICollection<ForumDTO> Forums { get; set; }
        public virtual ICollection<PantryDTO> Pantries { get; set; }
        public virtual ICollection<RecipeDTO> Recipes { get; set; }
        
    }
}
