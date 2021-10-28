using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Commons.DataTransferObjects
{
    public partial class PantryDTO
    {
        public PantryDTO()
        {
            Appliances = new HashSet<ApplianceDTO>();
            Ingredients = new HashSet<IngredientDTO>();
        }
        public string Name { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ICollection<ApplianceDTO> Appliances { get; set; }
        public virtual ICollection<IngredientDTO> Ingredients { get; set; }
    }
}
