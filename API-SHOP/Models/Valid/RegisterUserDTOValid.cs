using API_SHOP.Data;
using FluentValidation;

namespace API_SHOP.Models.Valid
{
    public class RegisterUserDTOValid : AbstractValidator<RegisterUserDTO>
    {
        public RegisterUserDTOValid(ShopDbContext dbContext)
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .Custom((v, y) =>
                {
                    var loginUse= dbContext.Users?.Any(x => x.Login == v);
                    if (loginUse != null && loginUse == true) 
                        y.AddFailure("Login", "There is already an account to the given e-mail address");
                });
            RuleFor(x => x.Password).MinimumLength(4);
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password);
           
        }
    }
}
