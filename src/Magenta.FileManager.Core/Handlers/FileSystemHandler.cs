using System;

namespace Magenta.FileManager.Core.Handlers
{
    public class FileSystemHandler
    {
        public byte[] Get(string path)
        {
            throw new NotImplementedException();
        }

        public void Save(string path, byte[] fileBytes)
        {
            throw new NotImplementedException();
        }
        
        public void Update(string oldPath, string newPath, byte[] newFileBytes)
        {
            throw new NotImplementedException();
        }
        
        public void Delete(string path)
        {
            throw new NotImplementedException();
        }
    }
}
