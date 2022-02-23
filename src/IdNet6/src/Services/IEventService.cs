﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdNet6.Events;
using System.Threading.Tasks;

namespace IdNet6.Services
{
    /// <summary>
    /// Interface for the event service
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// Raises the specified event.
        /// </summary>
        /// <param name="evt">The event.</param>
        Task RaiseAsync(Event evt);

        /// <summary>
        /// Indicates if the type of event will be persisted.
        /// </summary>
        bool CanRaiseEventType(EventTypes evtType);
    }
}