using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdNet6.Models;
using IdNet6.Test;
using Microsoft.Extensions.Logging;

namespace IdentityServerHost.Extensions
{
    public class HostProfileService : TestUserProfileService
    {
        public HostProfileService(TestUserStore users, ILogger<TestUserProfileService> logger) : base(users, logger)
        {
        }

        public override async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            await base.GetProfileDataAsync(context);

            var transaction = context.RequestedResources.ParsedScopes.FirstOrDefault(x => x.ParsedName == "transaction");
            if (transaction?.ParsedParameter != null)
            {
                context.IssuedClaims.Add(new Claim("transaction_id", transaction.ParsedParameter));
            }
        }
    }
}