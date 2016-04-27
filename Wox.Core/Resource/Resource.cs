﻿using System.IO;
using System.Windows;
using Wox.Infrastructure;

namespace Wox.Core.Resource
{
    public abstract class Resource
    {
        public string DirectoryName { get; protected set; }

        protected string DirectoryPath => Path.Combine(Infrastructure.Wox.ProgramPath, DirectoryName);

        public abstract ResourceDictionary GetResourceDictionary();
    }
}
