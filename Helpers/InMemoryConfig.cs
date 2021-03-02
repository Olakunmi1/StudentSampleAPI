﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace StudentSampleAPI.Helpers
{
    public static class InMemoryConfig
    {
        //add IdentityResources:
        public static IEnumerable<IdentityServer4.Models.IdentityResource> GetIdentityResources() =>
         new List<IdentityResource>
         {
              new IdentityResources.OpenId(),
              new IdentityResources.Profile()
         };

        // add the users into the configuration:
        public static List<TestUser> GetUsers() =>
        new List<TestUser>
        {
          new TestUser
          {
              SubjectId = "a9ea0f25-b964-409f-bcce-c923266249b4",
              Username = "Mick",
              Password = "MickPassword",
              Claims = new List<Claim>
              {
                  new Claim("given_name", "Mick"),
                  new Claim("family_name", "Mining")
              }
          },
          new TestUser
          {
              SubjectId = "c95ddb8c-79ec-488a-a485-fe57a1462340",
              Username = "Jane",
              Password = "JanePassword",
              Claims = new List<Claim>
              {
                  new Claim("given_name", "Jane"),
                  new Claim("family_name", "Downing")
              }
          }
      };

        //add client:
        public static IEnumerable<Client> GetClients() =>
        new List<Client>
        {
           new Client
           {
                ClientId = "student",
                ClientSecrets = new [] { new Secret("Secret_Secret".Sha512()) },
                AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId }
            }
        };
    }
}
