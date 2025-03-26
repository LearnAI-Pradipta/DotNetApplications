using FileManager.Context;
using FileManager.Models;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Repository
{
    public class DbFileApiRepository
    {
        private readonly FileApiContext _fileApiContext;

        public DbFileApiRepository(FileApiContext fileApiContext) 
        {
            _fileApiContext = fileApiContext;
        }

        public async Task<IEnumerable<FileDetail>> GetFirst20Files()
        {
            return await _fileApiContext.FileDetails.Take(20).ToListAsync();
        }

        public async Task<FileDetail?> GetSelectedFile(string corId)
        {
            return await _fileApiContext.FileDetails.FirstOrDefaultAsync(x => x.CorelationId == corId);
        }

    }
}
