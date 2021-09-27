using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models
{
    public partial class Appliance
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual Pantry Pantry { get; set; }
    }
}
