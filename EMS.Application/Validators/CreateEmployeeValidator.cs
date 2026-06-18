using EMS.Application.DTOs.Employee;
using FluentValidation;

namespace EMS.Application.Validators;

public class CreateEmployeeValidator
    : AbstractValidator<CreateEmployeeDto>
{
    public CreateEmployeeValidator()
    {
        RuleFor(x => x.EmployeeCode)
            .NotEmpty()
            .WithMessage("Employee Code is required")
            .MaximumLength(20);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("First Name is required")
            .MaximumLength(100);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Last Name is required")
            .MaximumLength(100);

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email is required")
            .EmailAddress()
            .WithMessage("Invalid email format");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .WithMessage("Phone Number is required");

        RuleFor(x => x.Department)
            .NotEmpty()
            .WithMessage("Department is required");

        RuleFor(x => x.Designation)
            .NotEmpty()
            .WithMessage("Designation is required");

        RuleFor(x => x.DateOfJoining)
            .NotEmpty()
            .WithMessage("Date Of Joining is required");
    }
}