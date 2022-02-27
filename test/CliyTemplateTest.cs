// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Template.Tests;

using Boxed.DotnetNewTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

[TestClass]
public class CliyTemplateTest : IDisposable
{
    private const string TemplateSlnPath = "Cliy.sln";
    private bool disposedValue;

    public CliyTemplateTest() => DotnetNew.InstallAsync<CliyTemplateTest>(TemplateSlnPath).Wait();

    [TestMethod]
    public async Task DotnetRunWithDefaultArgumentsIsSuccessful()
    {
        await using var tempDirectory = TempDirectory.NewTempDirectory();
        var project = await tempDirectory.DotnetNewAsync("cliy");

        await project.DotnetRestoreAsync();
        await project.DotnetBuildAsync();
        await project.DotnetTestAsync();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                DotnetNew.UninstallAsync<CliyTemplateTest>(TemplateSlnPath).Wait();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
