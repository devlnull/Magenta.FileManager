using System;
using System.Threading.Tasks;

namespace Magenta.FileManager.Abstractions
{
    public interface IFileManager
    {
        Task<IFileEntity> CreateAsync(IFileInput file);
        Task<IFileEntity> UpdateAsync(Guid uniqueId, IFileInput fileInput);
        Task<IFileEntity> GetAsync(Guid uniqueId);
        Task<IFileEntity> DeleteAsync(Guid uniqueId);
    }
}
