using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c=>c.CategoryName).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(2);
            RuleFor(c => c.CategoryName).MaximumLength(25);


        }
    }
}
