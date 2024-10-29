using Site_Api.Entities;

namespace Site_Api.Services
{
    public interface IAuthenticationRepository
    {
        public User? ValidateUserCredentials(string username, string password);
    }
}
