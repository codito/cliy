// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DefaultWorkflowRequest : IWorkflowRequest
{
    private readonly Configuration config;

    public DefaultWorkflowRequest(Configuration config) => this.config = config;
}
