using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int? RecipeId { get; set; }
        public int? UserId { get; set; }
        public int? Rate { get; set; }
        public virtual User User { get; set; }
        public virtual Recipe Reciepe { get; set; }
    }
}
