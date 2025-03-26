using FileManager.Context;
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
            return Ok( await _dbFileApiRepository.GetFirst20Files());
        }

        [HttpGet("{CorId:Guid}")]       
        public async Task<IActionResult> GetSelectedFileAsync(string CorId)
        {
            return Ok( await _dbFileApiRepository.GetSelectedFile(CorId));
        }


    }
}
