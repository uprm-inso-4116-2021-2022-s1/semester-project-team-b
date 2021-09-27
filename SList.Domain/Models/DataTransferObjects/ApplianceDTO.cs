﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SList.Domain.Models.DataTransferObjects
{
    public partial class ApplianceDTO
    {
        public string Name { get; set; }
        public virtual RecipeDTO Recipe { get; set; }
        public virtual PantryDTO Pantry { get; set; }
    }
}
