using FluentValidation;

namespace UserManagementService.Models
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(t=>t.Username).NotNull();
            RuleFor(t=>t.Age).InclusiveBetween(18,60);
        }
    }
}