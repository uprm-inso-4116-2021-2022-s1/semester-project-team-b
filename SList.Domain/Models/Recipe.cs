using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            CommentPostNavigations = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }
        public int? CommentId { get; set; }
        public int? RatingId { get; set; }
        public int? IngredientId { get; set; }
        public int? ApplianceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Appliance Appliance { get; set; }
        public virtual Comment Comments { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual ICollection<Comment> CommentPostNavigations { get; set; }
    }
}
