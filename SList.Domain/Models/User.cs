using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Forums = new HashSet<Forum>();
            Pantries = new HashSet<Pantry>();
            Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Forum> Forums { get; set; }
        public virtual ICollection<Pantry> Pantries { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
