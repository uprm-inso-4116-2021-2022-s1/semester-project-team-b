using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Ingredients = new HashSet<Ingredient>();
            Appliances = new HashSet<Appliance>();
            Comments = new HashSet<Comment>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Steps { get; set; }
        public string Description { get; set; }
        
        public TimeSpan CookDuration 
        {
            get
            {
                var slots = CookTime
                    .Split(':')
                    .Select(m => Convert.ToInt32(m))
                    .ToList();
                //days:hours:minutes:seconds
                return new TimeSpan(slots[0], slots[1], slots[2], slots[3]);
            }

        } 
        public TimeSpan PrepDuration {
            get
            {
                var slots = PrepTime
                    .Split(':')
                    .Select( m  => Convert.ToInt32(m))
                    .ToList();
                //days:hours:minutes:seconds
                return new TimeSpan(slots[0], slots[1], slots[2], slots[3]);
            }

        }
        public string CookTime { get; set; }
        public string PrepTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Appliance> Appliances { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
