using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Commons.DataTransferObjects
{
    public class UserDTO
    {
        public UserDTO()
        {
            Comments = new List<CommentDTO>();
            Forums = new List<ForumDTO>();
            Pantries = new List<PantryDTO>();
            Recipes = new List<RecipeDTO>();
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; internal set; }
        public virtual IEnumerable<CommentDTO> Comments { get; set; }
        public virtual IEnumerable<ForumDTO> Forums { get; set; }
        public virtual IEnumerable<PantryDTO> Pantries { get; set; }
        public virtual IEnumerable<RecipeDTO> Recipes { get; set; }
        
    }
}
