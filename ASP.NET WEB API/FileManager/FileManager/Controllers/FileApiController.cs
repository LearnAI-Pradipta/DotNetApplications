using FileManager.Context;
using FileManager.Interface;
using FileManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FileApiController : ControllerBase
    { 
        private readonly IDbFileApiRepository _dbFileApiRepository;

        public FileApiController(IDbFileApiRepository dbFileApiRepository)
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
