// Copyright (c) My Company. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Cliy.Infra;

using Cliy.Core;

public class FileSystem : IFileSystem
{
    public void Copy(string source, string destination) => File.Copy(source, destination);

    public bool Exists(string path) => File.Exists(path);
}
