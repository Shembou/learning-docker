using Microsoft.AspNetCore.Identity;
using Site_Api.DbContexts;
using Site_Api.Entities;

namespace Site_Api.Services
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AuthenticationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User? ValidateUserCredentials(string username, string password)
        {
            var user = _dbContext.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            var pwHasher = new PasswordHasher<User>();
            var result = pwHasher.VerifyHashedPassword(user, user.Password, password);
            if (result == PasswordVerificationResult.Failed)
            {
                return null;
            }

            return user;
        }
    }
}
