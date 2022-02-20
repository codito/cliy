// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Core;

public record Configuration
{
    public string DatabasePath { get; set; } = string.Empty;

    public string DatabasePassword { get; set; } = string.Empty;

    public string SourcePath { get; set; } = string.Empty;
}
