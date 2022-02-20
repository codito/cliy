// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Data;

using System.Threading.Tasks;
using Cliy.Core;
using Cliy.Data.Models;
using SQLite;

public class SqlDataStore : IDataStore
{
    private readonly ILogger logger;
    private string databasePath = string.Empty;
    private string password = string.Empty;

    public SqlDataStore(ILogger logger)
    {
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    #region Configuration

    public void Configure(string databasePath, string password)
    {
        this.databasePath = databasePath;
        this.password = password;
    }

    public async Task<bool> ValidateConnection()
    {
        try
        {
            var db = await this.CreateConnection();
            var info = await db.Table<Info>().ToListAsync();
            return info?.Count > 1;
        }
        catch (SQLiteException ex)
        {
            this.logger.Error($"Invalid sql connection. Exception: {ex}");
        }

        return false;
    }

    #endregion

    private async Task<SQLiteAsyncConnection> CreateConnection()
    {
        var db = new SQLiteAsyncConnection(this.databasePath);

        if (!string.IsNullOrEmpty(this.password))
        {
            await db.QueryAsync<int>("PRAGMA cipher='aes128cbc'");
            await db.QueryAsync<int>($"PRAGMA key='{this.password}'");
        }

        return db;
    }
}
