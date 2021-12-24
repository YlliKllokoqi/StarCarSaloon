using FluentValidation;
using Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations.Car
{
    public class CreateCarValidation : AbstractValidator<CreateCarModel>
    {
        public CreateCarValidation()
        {
            RuleFor(x => x.Brand).NotEmpty().NotNull();
            RuleFor(x => x.Model).NotEmpty().NotNull();
            RuleFor(x => x.Body).NotEmpty().NotNull();
            RuleFor(x => x.Year).NotNull().LessThanOrEqualTo(2021).GreaterThan(1960);
            RuleFor(x => x.Mileage).LessThan(100000).GreaterThanOrEqualTo(0);
            RuleFor(x => x.FuelType).NotEmpty().NotNull();
            RuleFor(x => x.Transmission).NotEmpty().NotNull();
        }
    }
}
