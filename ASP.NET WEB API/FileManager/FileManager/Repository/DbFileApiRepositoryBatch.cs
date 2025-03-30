using FileManager.Context;
using FileManager.Interface;
using FileManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Repository
{
    public class DbFileApiRepositoryBatch : IDbFileApiRepository
    {
        private readonly FileApiContextBatch _fileApiContext;

        public DbFileApiRepositoryBatch(FileApiContextBatch fileApiContext) 
        {
            _fileApiContext = fileApiContext;
        }

        public async Task<IEnumerable<FileDetail>> GetFirst20FilesAsync()
        {
            return await _fileApiContext.FileDetails.Take(20).ToListAsync();
        }

        public async Task<FileDetail?> GetSelectedFileAsync(string corId)
        {
            return await _fileApiContext.FileDetails.FirstOrDefaultAsync(x => x.CorelationId == corId);
        }

        public async Task PostFileAsync(FileDetail fileDetails)
        {
            await _fileApiContext.FileDetails.AddAsync(fileDetails);
            _fileApiContext.SaveChanges();
        }

    }
}
