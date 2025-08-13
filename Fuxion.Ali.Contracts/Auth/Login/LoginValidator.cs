using FluentValidation;

namespace Fuxion.Ali.Contracts.Auth.Login
{
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator()
        {
            //validación de usuario
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("El usuario es obligatorio.")
                .Matches(@"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ]+$").WithMessage("El usuario solo puede contener letras y/o números.");

            //validación de contraseña
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
                .Matches(@"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ!@#$%^&*()_+={}\[\]:;\""'<>?,./\\-]+$").WithMessage("La contraseña solo puede contener letras, números y algunos caracteres especiales.");
        }
    }
}
