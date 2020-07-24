namespace Magenta.FileManager.Abstractions
{
    public interface IFileInput
    {
        byte[] Content { get; set; }
        string Extension { get; set; }
        string Name { get; set; }
    }
}
