using Microsoft.AspNetCore.Mvc;

namespace FileUploader.Controllers
{
    [Route("file-manager")]
    public class FileManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}