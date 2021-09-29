using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            Pantries = new HashSet<Pantry>();
            Recipes = new HashSet<Recipe>();
        }
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Pantry> Pantries { get; set; }
    }
}
