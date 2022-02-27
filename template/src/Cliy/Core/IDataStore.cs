// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Core;

using Cliy.Data.Models;

public interface IDataStore
{
    void Configure(string databasePath, string databasePassword);

    Task<bool> ValidateConnection();
}
