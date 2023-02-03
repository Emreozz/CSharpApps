using CoreV2.Entities.Concrete;
using CoreV2.Utilities.Results;
using CoreV2.Utilities.Security.JWT;
using EntitiesV2.DTOs;

namespace BusinessV2.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
