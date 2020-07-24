using Magenta.FileManager.Abstractions;

namespace Magenta.FileManager.Core.Path
{
    public interface IFilePathHandler
    {
        string GeneratePath(IFileEntity file);
    }
}
