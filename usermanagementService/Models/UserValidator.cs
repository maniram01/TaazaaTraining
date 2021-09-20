// ye model ke liye validation likhta hai----------
using FluentValidation;
namespace usermanagementService.Models
{
    public class UserValidator : AbstractValidator<User> // 
    {
        public UserValidator()
        {
            RuleFor(t=>t.Name).NotNull();
            RuleFor(t=>t.Age).InclusiveBetween(18,99);
        }
    }
}