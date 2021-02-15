using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.OpenApi.Models;
using System;

namespace azure_functions_openapi_oauth2_test
{
    class TestOAuth2 : OpenApiOAuthSecurityFlows
    {
        public TestOAuth2()
        {
            this.Implicit = new OpenApiOAuthFlow()
            {
                AuthorizationUrl = new Uri("https://xxxx.b2clogin.com/xxxx.onmicrosoft.com/oauth2/v2.0/authorize?p=workflow_id"),
                Scopes = { { "https://xxxx.onmicrosoft.com/xxxx-xxx/API.User", "API Access" } },
                TokenUrl = new Uri("https://xxxx.b2clogin.com/xxxx.onmicrosoft.com/oauth2/v2.0/token?p=workflow_id")
            };
        }
    }
}
