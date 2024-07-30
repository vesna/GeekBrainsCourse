using Contracts.Requests;
using Contracts.Responses;

namespace StoreMarket004.BLL.Abstractions
{
    public interface IAuthService
    {
        public string? Login(UserAuthRequest request);
        public string? Register(UserAuthRequest request);
    }
}
