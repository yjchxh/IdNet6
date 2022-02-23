﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdNet6.Models;
using IdNet6.Validation;
using System.Threading.Tasks;

namespace IdNet6.ResponseHandling
{
    /// <summary>
    /// Interface for determining if user must login or consent when making requests to the authorization endpoint.
    /// </summary>
    public interface IAuthorizeInteractionResponseGenerator
    {
        /// <summary>
        /// Processes the interaction logic.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="consent">The consent.</param>
        /// <returns></returns>
        Task<InteractionResponse> ProcessInteractionAsync(ValidatedAuthorizeRequest request, ConsentResponse consent = null);
    }
}