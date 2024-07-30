namespace StoreMarket004.BLL.Abstractions
{
    public interface ITokenService
    {
        string GenerateToken(string email, string roleName);
    }
}
