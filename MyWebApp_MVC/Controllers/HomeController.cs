using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApp_MVC.DBLayer;
using MyWebApp_MVC.Models;
using MyWebApp_MVC.Repository;
using System.Diagnostics;

namespace MyWebApp_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FileSystemContext _applicationDbContext;
        private readonly IFileSystemRepository _fileSystemRepository;

        public HomeController(ILogger<HomeController> logger, 
                                FileSystemContext applicationDbContext,
                                IFileSystemRepository fileSystemRepository)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
            _fileSystemRepository = fileSystemRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _fileSystemRepository.GetAllFileDetailsAsync();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
