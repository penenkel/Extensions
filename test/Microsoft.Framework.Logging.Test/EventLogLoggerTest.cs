﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.Logging.EventLog;
using Xunit;

namespace Microsoft.Framework.Logging
{
    public class EventLogLoggerTest
    {
        [Fact]
        public void CallingBeginScopeOnLogger_AlwaysReturnsNewDisposableInstance()
        {
            // Arrange
            var logger = new EventLogLogger("Test");

            // Act
            var disposable1 = logger.BeginScopeImpl("Scope1");
            var disposable2 = logger.BeginScopeImpl("Scope2");

            // Assert
            Assert.NotNull(disposable1);
            Assert.NotNull(disposable2);
            Assert.NotSame(disposable1, disposable2);
        }

        [Fact]
        public void CallingBeginScopeOnLogger_ReturnsNonNullableInstance()
        {
            // Arrange
            var logger = new EventLogLogger("Test");

            // Act
            var disposable = logger.BeginScopeImpl("Scope1");

            // Assert
            Assert.NotNull(disposable);
        }
    }
}
