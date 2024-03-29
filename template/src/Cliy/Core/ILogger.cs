﻿// Copyright (c) My Company. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Core;

/// <summary>
/// Provides logging primitives with various levels.
/// </summary>
public interface ILogger
{
    public void Configure(LogLevel level);

    public void Error(string message);

    public void Warn(string message);

    public void Verbose(string message);
}