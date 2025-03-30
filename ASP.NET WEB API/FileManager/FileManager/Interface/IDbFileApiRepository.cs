using FileManager.Models;

namespace FileManager.Interface
{
    public interface IDbFileApiRepository
    {
        Task<IEnumerable<FileDetail>> GetFirst20FilesAsync();
        Task<FileDetail?> GetSelectedFileAsync(string corId);
        Task PostFileAsync(FileDetail fileDetails);

    }
}
