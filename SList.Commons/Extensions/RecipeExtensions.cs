using SList.Commons.DataTransferObjects;
using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Commons.Extensions
{
    public static class RecipeExtensions
    {
        public static RecipeDTO ToRecipeDTO(this Recipe recipe) =>
            new RecipeDTO
            {
            };

    }
}
