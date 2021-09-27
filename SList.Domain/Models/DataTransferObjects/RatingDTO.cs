using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models.DataTransferObjects
{
    public partial class RatingDTO
    {
        public int? Rating { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual RecipeDTO Reciepe { get; set; }
    }
}
