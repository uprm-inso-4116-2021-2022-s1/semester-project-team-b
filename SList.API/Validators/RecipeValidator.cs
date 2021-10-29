using FluentValidation;
using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Validators
{
    public class RecipeValidator : AbstractValidator<RecipeDTO>
    {
        public RecipeValidator(
            IValidator<ApplianceDTO> applianceValidator, 
            IValidator<IngredientDTO> ingredientValidator,
            IValidator<UserDTO> userValidator)
        {
            RuleForEach(r => r.Appliances).SetValidator(applianceValidator);
            RuleForEach(r => r.Ingredients).SetValidator(ingredientValidator);
            RuleFor(r => r.User).SetValidator(userValidator);
        }
    }
}
