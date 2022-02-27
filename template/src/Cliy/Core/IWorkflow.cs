// Copyright (c) My Company. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Core;

public interface IWorkflow
{
    Task<IWorkflowResponse> RunAsync(IWorkflowRequest request);
}

public interface IWorkflowRequest
{
}

public interface IWorkflowResponse
{
    // TODO: error code, error message etc.
}

/// <summary>
/// Represents a service container and composition root.
/// </summary>
public interface IHost
{
    T GetService<T>();
}
