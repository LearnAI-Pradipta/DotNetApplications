//Service Provider Web Api
//FileSystemController.cs
[Route("api/[controller]")
[ApiConbtroller]
FileSystemController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IMemoryCache _cache;
    private ApplicationDBContext _appDbContext;
    private readOnly string cacheKey = "CacheKey";

    FileSystemController(ApplicationDBContext appDbContext,ILogger logger,IMemoryCache cache)
    {
        _appDbContext = appDbContext;
        _logger = logger;
        _cache = cache;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllFileSystems()
    {
        _logger.logInformation("AAAA");
        if(_cache.TryGetValue("cacheKey", out list<FileSystem> allFileSystem))
        {
            _logger.logInformation("AAAA");
        } 
        else
        {
            var allFileSystem = _appDbContext.FileSystem.TolistAsync();
            var cacheOption = //Create the option for the cache to retain the data in memory
            _cache.AddValue("cacheKey",allFileSystem,cacheOption)
        }
        return 
    }

    [HttpPost]
    public async Task<IActionResult> CreateFileSystems(FileSystem fileSystem)
    {
        _appDbContext.FileSystem.AddAsync(fileSystem);
        _appDbContext.SaveChangesAsync();
        return CreatedAtAction("GetAllFile",fileSystem);
    }

}



//Program.cs
var builder = WebApplication.CreateBuilder();
builder.services.AddDbContext(ApplicationDBContext);
builder.services.AddMemoryCache()



//Consumer.cs
main.cs

public void GetAllFileDetails()
{
    using(HttpClient httpClient = new HttpClient())
    {
        var response = httpClient.Get(api_url)
    }
}