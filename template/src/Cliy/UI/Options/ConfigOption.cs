﻿// Copyright (c) My Company. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.UI.Commands;

using System.CommandLine;
using Cliy.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class ConfigOption : Option<Configuration>, ICommandOption
{
    public ConfigOption()
        : base(
            new[] { "-c", "--config" },
            parseArgument: (result) => result.Tokens.Count > 1 ? Parse(result.Tokens[result.Tokens.Count - 1].Value) : new Configuration(),
            isDefault: true,
            "Path to a configuration file.")
    {
    }

    public bool Global => true;

    private static Configuration Parse(string filePath)
    {
        var configFile = new FileInfo(filePath);
        var configStream = configFile.OpenRead();
        using var configReader = new StreamReader(configStream);
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();

        var config = deserializer.Deserialize<Configuration>(configReader);
        config.SourcePath = filePath;

        // Resolve relative database path.
        if (!string.IsNullOrEmpty(config.DatabasePath) && !Path.IsPathRooted(config.DatabasePath))
        {
            var sourceDir = Path.GetDirectoryName(config.SourcePath) ?? string.Empty;
            config.DatabasePath = Path.GetFullPath(Path.Combine(sourceDir, config.DatabasePath));
        }

        return config;
    }
}
