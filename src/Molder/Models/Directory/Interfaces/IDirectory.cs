﻿using System.Collections.Generic;
using System.IO;

namespace Molder.Models.Directory.Interfaces
{
    public interface IDirectory
    {
        void Create();
        string Get();
        bool Exists();
        IEnumerable<FileInfo> GetFiles(string searchPattern);
    }
}