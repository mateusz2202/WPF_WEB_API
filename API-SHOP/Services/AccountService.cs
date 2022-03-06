using API_SHOP.Data;
using API_SHOP.Entities;
using API_SHOP.Exceptions;
using API_SHOP.IServices;
using API_SHOP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_SHOP.Services
{
    public class AccountService : IAccountService
    {
        private readonly ShopDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly AuthenticationSettings _authenticationSettings;

        public AccountService(ShopDbContext dbContext, IPasswordHasher<User> passwordHasher, AuthenticationSettings authenticationSettings)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
            _authenticationSettings = authenticationSettings;
        }

        public string GetToken(LoginDTO dto)
        {
            var user=_dbContext.Users?.Include(u=>u.Role).FirstOrDefault();
            if (user is null) throw new BadRequestException("error login: invalid passwrod or login");
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, dto.Password);
            if(result==PasswordVerificationResult.Failed) throw new BadRequestException("error login: invalid passwrod or login");
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name,$"{user.Name} {user.LastName}"),
                new Claim(ClaimTypes.Role,$"{user?.Role?.Name}")
            };
            if (_authenticationSettings.JwtKey == null) throw new Exception(); 
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);
            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public void RegisterUser(RegisterUserDTO dto)
        {
            var user = new User()
            {
                Name = dto.UserName,
                LastName = dto.LastName,
                Login = dto.Email,
                RoleId = dto.RoleId,
            };
            var hashedPassword=_passwordHasher.HashPassword(user, dto.Password);
            user.Password = hashedPassword;
            _dbContext.Users?.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
