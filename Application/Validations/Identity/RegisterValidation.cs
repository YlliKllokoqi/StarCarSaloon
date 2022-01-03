using FluentValidation;
using Model.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations.Identity
{
    public class RegisterValidation : AbstractValidator<RegisterModel>
    {
        public RegisterValidation()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).MaximumLength(30);
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password);
        }
    }
}
