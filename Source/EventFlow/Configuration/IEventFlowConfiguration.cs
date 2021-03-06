﻿// The MIT License (MIT)
// 
// Copyright (c) 2015-2017 Rasmus Mikkelsen
// Copyright (c) 2015-2017 eBay Software Foundation
// https://github.com/eventflow/EventFlow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using Newtonsoft.Json;

namespace EventFlow.Configuration
{
    public interface IEventFlowConfiguration
    {
        /// <summary>
        /// Number of events to load from the event persistance when read models
        /// are populated.
        /// </summary>
        /// <remarks>Defaults to 200</remarks>
        int PopulateReadModelEventPageSize { get; }

        /// <summary>
        /// Use by <c>OptimisticConcurrencyRetryStrategy</c> to determine the number
        /// of retries when an optimistic concurrency exceptions is thrown from the
        /// event persistance.
        /// 
        /// If more fine grained control of is needed, a custom implementation of
        /// <c>IOptimisticConcurrencyRetryStrategy</c> should be provided.
        /// </summary>
        /// <remarks>Defaults to 4</remarks>
        int NumberOfRetriesOnOptimisticConcurrencyExceptions { get; }

        /// <summary>
        /// Use by <c>OptimisticConcurrencyRetryStrategy</c> to determine the delay
        /// between retries when an optimistic concurrency exceptions is thrown from the
        /// event persistance.
        /// 
        /// If more fine grained control of is needed, a custom implementation of
        /// <c>IOptimisticConcurrencyRetryStrategy</c> should be provided.
        /// </summary>
        /// <remarks>Defaults to 100 ms</remarks>
        TimeSpan DelayBeforeRetryOnOptimisticConcurrencyExceptions { get; }

        /// <summary>
        /// Should EventFlow throw exceptions thrown by subscibers when publishing
        /// domain events.
        /// </summary>
        /// <remarks>Defaults to false</remarks>
        bool ThrowSubscriberExceptions { get; }

        /// <summary>
        /// Should EventFlow schedule a job to invoke asynchronous domain event
        /// subscribers
        /// </summary>
        /// <remarks>Defaults to false</remarks>
        bool IsAsynchronousSubscribersEnabled { get; }

        /// <summary>
        /// Configuration settings for the EventFlow Json Serializer
        /// </summary>
        JsonSerializerSettings SerializerSettings { get; set; }
    }
}