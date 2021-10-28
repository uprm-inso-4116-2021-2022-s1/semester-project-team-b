using SList.Commons.DataTransferObjects;
using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Commons.Extensions
{
    public static class PantryExtensions
    {
        public static PantryDTO ToPantryDTO(this Pantry pantry) =>
            new PantryDTO
            {
            };

    }
}
