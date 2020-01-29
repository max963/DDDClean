using System;
using Domain.Entities;
using FluentValidation;

namespace Service.Validators
{
    public class UsuarioValidator: AbstractValidator<User>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .OnAnyFailure(x => {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(x => x.Cpf)
                .NotEmpty().WithMessage("its necessary to inform the CPF")
                .NotNull().WithMessage("its necessary to inform the CPF");

            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("its necessary to inform the BirthDate")
                .NotNull().WithMessage("its necessary to inform the BirthDate");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("its necessary to inform the Name")
                .NotNull().WithMessage("its necessary to inform the Name");

        }
    }
}