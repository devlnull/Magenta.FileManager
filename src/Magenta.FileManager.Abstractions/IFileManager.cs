using System.Threading.Tasks;

namespace Magenta.FileManager.Abstractions
{
    public interface IFileManager
    {
        Task<IFileEntity> CreateAsync(IFileInput file);
    }
}
