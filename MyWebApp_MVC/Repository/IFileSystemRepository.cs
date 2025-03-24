using MyWebApp_MVC.Models;

namespace MyWebApp_MVC.Repository
{
    public interface IFileSystemRepository
    {
        Task<IEnumerable<FileDetail>> GetAllFileDetailsAsync();
    }
}
