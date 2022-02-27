// Copyright (c) Arun Mahapatra. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Tests.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliy.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HostTests
{
    [DataTestMethod]
    [DataRow(typeof(ILogger))]
    public void GetServiceReturnsRegisteredInstance(Type instanceType)
    {
    }
}
