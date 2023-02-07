using FluentValidation;

namespace Application.Validations
{
    public static class ValidatorUtility
    {
        public static string FluentValidate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            //var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
                return string.Join(",", result.Errors);

            return "";
        }
    }
}
