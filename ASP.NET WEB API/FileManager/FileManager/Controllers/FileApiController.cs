using FileManager.Context;
using FileManager.Models;
using FileManager.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileApiController : ControllerBase
    {
        private readonly DbFileApiRepository _dbFileApiRepository;

        public FileApiController(DbFileApiRepository dbFileApiRepository)
        {
            _dbFileApiRepository = dbFileApiRepository;
        }

        [HttpGet]        
        public async Task<IActionResult> GetFirstFewFilesAsync()
        {            
            return Ok( await _dbFileApiRepository.GetFirst20FilesAsync());
        }

        [HttpGet("{CorId}")]       
        public async Task<IActionResult> GetSelectedFileAsync(string CorId)
        {
            return Ok( await _dbFileApiRepository.GetSelectedFileAsync(CorId));
        }

        [HttpPost]
        public async Task<IActionResult> PostFileAsync(FileDetail fileDetail)
        {
            await _dbFileApiRepository.PostFileAsync(fileDetail);

            return CreatedAtAction("GetFirstFewFiles", new { Id = fileDetail.FileId} );
        }


    }
}
