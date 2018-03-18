using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using TwoFactorAuthDemo.Models;
using System.Configuration;
using YubicoDotNetClient;

namespace TwoFactorAuthDemo
{
    public class YubikeyOTPProvider : IUserTokenProvider<ApplicationUser, string>
    {
        public Task<string> GenerateAsync(string purpose, UserManager<ApplicationUser, string> manager, ApplicationUser user)
        {
            return Task.FromResult((string)null);
        }

        public Task<bool> IsValidProviderForUserAsync(UserManager<ApplicationUser, string> manager, ApplicationUser user)
        {
            return Task.FromResult(user.IsYubikeyOTPEnabled);
        }

        public Task NotifyAsync(string token, UserManager<ApplicationUser, string> manager, ApplicationUser user)
        {
            return Task.FromResult(true);
        }

        public async Task<bool> ValidateAsync(string purpose, string token, UserManager<ApplicationUser, string> manager, ApplicationUser user)
        {
            var clientId = ConfigurationManager.AppSettings["YubikeyClientId"];
            var secret = ConfigurationManager.AppSettings["YubikeyAPIKey"];

            var client = new YubicoClient(clientId, secret);
            var response = await client.VerifyAsync(token);

            if(response != null)
            {
                if(response.Status == YubicoResponseStatus.Ok)
                {
                    return true;
                }
            }

            return false;
        }
    }
}