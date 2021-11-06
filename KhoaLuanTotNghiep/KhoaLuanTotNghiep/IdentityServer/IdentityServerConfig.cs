using IdentityServer4;
using IdentityServer4.Models;
using ShareModel;
using ShareModel.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.IdentityServer
{
    public class IdentityServerConfig
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                new List<IdentityResource>
                {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                };

        public static IEnumerable<ApiScope> ApiScopes =>
             new ApiScope[]
             {
                  new ApiScope("KhoaLuan.api", "Khoa Luan API")
             };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                // machine to machine client
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // scopes that client has access to
                    AllowedScopes = { "KhoaLuan.api" }
                },

                // interactive ASP.NET Core MVC client
                new Client
                {
                    ClientId = "mvc",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { ClientUrlMVC.REDIRECT_URI_MVC },

                    PostLogoutRedirectUris = { ClientUrlMVC.POST_LOGOUT_REDIRECT_URI_MVC },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "KhoaLuan.api"
                    }
                },

                new Client
                {
                    ClientId = "swagger",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,

                    RequireConsent = false,
                    RequirePkce = true,

                    RedirectUris =           { ClientUrlSwagger.REDIRECT_URI_SWAGGER },
                    PostLogoutRedirectUris = { ClientUrlSwagger.POST_LOGOUT_REDIRECT_URI_SWAGGER },
                    AllowedCorsOrigins =     { ClientUrlSwagger.ALLOWED_CORS_ORIGIN_SWAGGER },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "KhoaLuan.api"
                    }
                },


                new Client
                {
                    ClientName="admin",
                    ClientId = "admin",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RequireClientSecret = false,
                    RequireConsent = false,
                    AlwaysSendClientClaims = true,
                    AllowOfflineAccess = true,
                    AlwaysIncludeUserClaimsInIdToken = true,

                    RedirectUris = new List<string>          
                    {
                        ClientUrlReact.REDIRECT_URI_REACT_AUTH,
                        ClientUrlReact.REDIRECT_URI_REACT_RENEW,
                        ClientUrlReact.REDIRECT_URI_REACT_DEFAULT
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        ClientUrlReact.POST_LOGOUT_REDIRECT_URI_REACT_AUTH,
                        ClientUrlReact.POST_LOGOUT_REDIRECT_URI_REACT_RENEW,
                        ClientUrlReact.POST_LOGOUT_REDIRECT_URI_REACT_DEFAULT
                    },
                    AllowedCorsOrigins =     
                    {
                        ClientUrlReact.ALLOWWED_CORS_ORIGIN
                    },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OfflineAccess,
                        "KhoaLuan.api"
                    }
                },
            };
    }
}
