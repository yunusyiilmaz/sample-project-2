using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail> 
    {
        public ShippingDetailValidator()
        {
            RuleFor(expression: s => s.FirstName).NotEmpty().WithMessage("Ad gereklidir");
            RuleFor(expression: s => s.FirstName).MinimumLength(2);
            RuleFor(expression: s => s.lastName).NotEmpty();
            RuleFor(expression: s => s.Adress).NotEmpty();
            RuleFor(expression: s => s.City).NotEmpty();
            
        }
    }
}
