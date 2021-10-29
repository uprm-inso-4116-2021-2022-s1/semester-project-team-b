using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace SList.Commons.DataTransferObjects
{
    public class RecipeDTO
    {
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public UserDTO User { get; set; }
        public IEnumerable<ApplianceDTO> Appliances { get; set; }
        public IEnumerable<IngredientDTO> Ingredients { get; set; }
        public IEnumerable<RatingDTO> Ratings { get; set; }
        public double OverallRating() => Ratings?.Sum(r => r.Rating) / Ratings?.Count() ?? 0;
        public IEnumerable<CommentDTO> Comments { get; set; }
    }
}
