using FluentValidation;

namespace Fuxion.Ali.Contracts.Users.Update
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            //Validacion de usuario
            RuleFor(x => x.UserName).NotEmpty().WithMessage("El nombre de usuario es obligatorio.")
                                    .MaximumLength(100).WithMessage("El nombre de usuario no puede exceder los 100 caracteres.");
            //Validacion de rol
            RuleFor(x => x.RoleId).NotEmpty().WithMessage("El rol es obligatorio.");
            //Validacion de nombre
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("El campo es obligatorio.")
                                    .MaximumLength(100).WithMessage("El campo no puede exceder los 100 caracteres.");
            //Validacion de apellido
            RuleFor(x => x.LastName).NotEmpty().WithMessage("El campo es obligatorio.")
                                    .MaximumLength(100).WithMessage("El campo no puede exceder los 100 caracteres.");
            //Validacion de email
            RuleFor(x => x.Email).NotEmpty().WithMessage("El email es obligatorio.")
                                 .EmailAddress().WithMessage("El email no es válido.")
                                 .MaximumLength(100).WithMessage("El email no puede exceder los 100 caracteres.");
            //Validacion de telefono
            RuleFor(x => x.Phone).NotEmpty().WithMessage("El teléfono es obligatorio.")
                                 .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("El teléfono no es válido.")
                                 .MaximumLength(15).WithMessage("El teléfono no puede exceder los 25 caracteres.");
        }
    }
}
