// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Template.Tests;

using Boxed.DotnetNewTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

[TestClass]
public class CliyTemplateTest
{
    private const string TemplateSlnPath = "Cliy.sln";

    [TestMethod]
    public async Task DotnetRunWithDefaultArgumentsIsSuccessful()
    {
        await DotnetNew.InstallAsync<CliyTemplateTest>(TemplateSlnPath);
        await using var tempDirectory = TempDirectory.NewTempDirectory();
        var project = await tempDirectory.DotnetNewAsync("cliy");

        await project.DotnetRestoreAsync();
        await project.DotnetBuildAsync();
        await project.DotnetTestAsync();
    }
}
