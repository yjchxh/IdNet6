﻿using IdNet6.Models;
using IdNet6.Stores;
using System;
using System.Threading.Tasks;

namespace IdentityServer.UnitTests.Common
{
    class MockReferenceTokenStore : IReferenceTokenStore
    {
        public Task<Token> GetReferenceTokenAsync(string handle)
        {
            throw new NotImplementedException();
        }

        public Task RemoveReferenceTokenAsync(string handle)
        {
            throw new NotImplementedException();
        }

        public Task RemoveReferenceTokensAsync(string subjectId, string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<string> StoreReferenceTokenAsync(Token token)
        {
            throw new NotImplementedException();
        }
    }
}
