using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Pantry
    {
        public Pantry()
        {
            Appliances = new HashSet<Appliance>();
            Ingredients = new HashSet<Ingredient>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IngredientId { get; set; }
        public int? ApplianceId { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Appliance> Appliances { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
