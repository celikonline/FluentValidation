using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationCore31.Validations
{
     public class ContactDtoValidator : AbstractValidator<ContactDTO>
    {
        public ContactDtoValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).Length(5);
        }
    }
}
