// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.UI.Commands;

using System.CommandLine;
using System.CommandLine.Invocation;

public class DefaultCommand : RootCommand
{
    public DefaultCommand(IEnumerable<ICommandOption> options, IEnumerable<Command> commands)
    {
        this.Description = "TODO: tool description goes here.";
        this.Name = "TODO";

        foreach (var opt in options)
        {
            if (opt is Option o)
            {
                this.AddGlobalOption(o);
            }
        }

        foreach (var command in commands)
        {
            this.AddCommand(command);
        }
    }
}