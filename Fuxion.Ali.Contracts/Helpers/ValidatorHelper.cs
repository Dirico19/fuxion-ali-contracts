using FluentValidation;
using FluentValidation.Results;

namespace Fuxion.Ali.Contracts.Helpers
{
    public static class ValidatorHelper
    {
        public static Func<object, string, Task<IEnumerable<string>>> ValidateValue<T>(this IValidator<T> validator) where T : class
        {
            return async (model, propertyName) =>
            {
                if (model is not T castModel)
                    return [$"Tipo de modelo inválido: se esperaba {typeof(T).Name}, se recibió {model?.GetType().Name}"];

                var context = ValidationContext<T>.CreateWithOptions(castModel, opts =>
                    opts.IncludeProperties(propertyName));

                ValidationResult result = await validator.ValidateAsync(context);

                return result.IsValid
                    ? []
                    : result.Errors.Select(e => e.ErrorMessage);
            };
        }
    }
}
