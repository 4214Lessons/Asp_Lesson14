using Microsoft.AspNetCore.Authorization;

namespace Lesson10Areas.Services.Claims
{
    public class EmailRequirement : IAuthorizationRequirement
    {
        public string? Domain { get; set; }

        public EmailRequirement(string? domain)
        {
            Domain = domain;
        }
    }
}
