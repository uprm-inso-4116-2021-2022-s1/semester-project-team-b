using FluentValidation;
using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Validators
{
    public class IngredientValidator : AbstractValidator<IngredientDTO>
    {
        public IngredientValidator()
        {
            RuleFor(i => i.Name).NotEmpty().NotNull();
            RuleFor(i => i.Quantity).GreaterThan(0);
        }
    }
}
