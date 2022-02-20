// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Tests.UI;

using Cliy.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class HostTests
{
    [DataTestMethod]
    [DataRow(typeof(ILogger))]
    public void GetServiceReturnsRegisteredInstance(Type instanceType)
    {
    }
}
