using API_SHOP.Models;

namespace API_SHOP.IServices
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDTO dto);
        string GetToken(LoginDTO dto);
    }
}
