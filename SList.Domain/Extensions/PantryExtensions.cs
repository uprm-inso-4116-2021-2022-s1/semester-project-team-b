using SList.Domain.Models;
using SList.Domain.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Extensions
{
    public static class PantryExtensions
    {
        public static PantryDTO ToPantryDTO(this Pantry pantry) =>
            new PantryDTO
            {
            };

    }
}
