using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace SList.Domain.Models.DataTransferObjects
{
    public partial class RecipeDTO
    {
        public RecipeDTO()
        {
            Comments = new HashSet<CommentDTO>();
        }
        public string Content { get; set; }
        public byte[] CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ApplianceDTO Appliance { get; set; }
        public virtual IngredientDTO Ingredient { get; set; }
        public virtual ICollection<RatingDTO> Ratings { get; set; }
        public int? OverallRating() => Ratings?.Sum(r => r.Rating) / Ratings?.Count();
        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
