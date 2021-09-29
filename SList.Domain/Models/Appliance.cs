using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Appliance
    {
        public Appliance()
        {
            Recipes = new HashSet<Recipe>();
            Pantries = new HashSet<Pantry>();

        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Pantry> Pantries { get; set; }
    }
}
