﻿using System;

namespace Magenta.FileManager.Abstractions
{
    public interface IFileEntity
    {
        string Path { get; }
        string Name { get; }
        string Extension { get; }
        string DirectoryPath { get; }
        long Size { get; }
        DateTime CreateDate { get; }
        DateTime LastModified { get; }
        public Guid UniqueId { get; set; }
    }
}
