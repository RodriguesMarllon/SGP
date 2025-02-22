using FluentValidation;

namespace Application.Handlers.Employees.RequestBody
{
    public class CreateEmployeeBodyValidator : AbstractValidator<CreateEmployeeBodyRequest>
    {
        public CreateEmployeeBodyValidator()
        {
        }
    }
}
