using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;
        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDTO> AssignRoleAsync(RegistrationRequestDTO registrationRequestDTO)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDTO,
                Url = SD.AuthAPIBase + "/api/auth/AssignRole"
            });
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<ResponseDTO> LoginAsync(LoginRequestDTO loginRequestDTO)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Data = loginRequestDTO,
                Url = SD.AuthAPIBase + "/api/auth/login"
            }, withBearer: false);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<ResponseDTO> RegisterAsync(RegistrationRequestDTO registrationRequestDTO)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDTO,
                Url = SD.AuthAPIBase + "/api/auth/register"
            }, withBearer: false);
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
