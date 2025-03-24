using Microsoft.EntityFrameworkCore;
using MyWebApp_MVC.DBLayer;
using MyWebApp_MVC.Models;

namespace MyWebApp_MVC.Repository
{
    public class FileSystemRepository : IFileSystemRepository
    {
        private readonly FileSystemContext _fileSystemContext;

        public FileSystemRepository(FileSystemContext fileSystemContext)
        {
            _fileSystemContext = fileSystemContext;
        }

        public async Task<IEnumerable<FileDetail>> GetAllFileDetailsAsync()
        {
            return await _fileSystemContext.FileDetails.ToListAsync();            
        }
    }
}
