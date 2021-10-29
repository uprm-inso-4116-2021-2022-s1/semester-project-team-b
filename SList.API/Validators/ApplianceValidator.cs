using FluentValidation;
using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Validators
{
    public class ApplianceValidator : AbstractValidator<ApplianceDTO>
    {
        public ApplianceValidator()
        {
            RuleFor(a => a.Name)
                .NotNull()
                .NotEmpty();
        }
    }
}
