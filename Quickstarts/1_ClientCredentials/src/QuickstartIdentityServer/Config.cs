// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4.Models;
using System.Collections.Generic;

namespace QuickstartIdentityServer
{
    public class Config
    {
        // scopes define the API resources in your system
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                //new ApiResource("api1", "My API")
                new ApiResource()
                {
                    Name = "api1",
                    DisplayName = "My new api",

                    Scopes =
                    {
                        new Scope()
                        {
                            Name = "books",
                            DisplayName = "full access to books api"
                        },
                        new Scope()
                        {
                            Name = "api1",
                            DisplayName = "entire api?"
                        }
                    }
                }
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets = 
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" }
                },
                new Client()
                {
                    ClientId = "booksClient",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("booksSecret".Sha256())
                    },
                    AllowedScopes = { "api1", "books" }
                    
                }
            };
        }
    }
}