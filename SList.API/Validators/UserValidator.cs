using FluentValidation;
using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(u => u.FirstName).NotEmpty().NotNull();
            RuleFor(u => u.LastName).NotEmpty().NotNull();
            RuleFor(u => u.Username).NotEmpty().NotNull().Length(6, 15);
            RuleFor(u => u.Password).NotEmpty().NotNull().Length(6, 15);
        }
    }
}
