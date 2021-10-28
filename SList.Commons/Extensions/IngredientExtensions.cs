using SList.Commons.DataTransferObjects;
using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Commons.Extensions
{
    public static class IngredientExtensions
    {
        public static IngredientDTO ToIngredientDTO(this Ingredient ingredient) =>
            new IngredientDTO
            {
            };

    }
}
