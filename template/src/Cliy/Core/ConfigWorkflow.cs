// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConfigWorkflow : IWorkflow
{
    private readonly IHost host;

    public ConfigWorkflow(IHost host)
    {
        if (host == null)
        {
            throw new ArgumentNullException(nameof(host));
        }

        this.host = host;
    }

    public Task<IWorkflowResponse> RunAsync(IWorkflowRequest request)
    {
        throw new NotImplementedException();
    }
}
