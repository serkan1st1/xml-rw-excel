using Microsoft.AspNetCore.Mvc;
using TaskMvc.Models;
using System.Xml.Linq;
using TaskMvc.Business;
using System.Xml.Serialization;
using System.IO;
using TaskMvc.Interface;


namespace TaskMvc.Controllers
{
    public class FileUploadController : Controller
    {

        private readonly IFileUploadService _fileUploadService;
        private readonly IFileSaveService _fileSaveService;


        public FileUploadController(IFileUploadService fileUploadService, IFileSaveService fileSaveService)
        {
            _fileUploadService = fileUploadService;
            _fileSaveService = fileSaveService;
        }


        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var path="";
            if (file == null || file.Length == 0)
            {
                return BadRequest("Dosya seçilmedi.");
            }
            try
            {
                path = await _fileUploadService.UploadFileAsync(file);
                var genelBilgiler = await _fileSaveService.DeserializeXmlAsync(path);  //genelBilgiler daha sonra kullanılabilir.

                return Ok("Dosya başarıyla yüklendi ve ayrıştırıldı.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message);
            }

        }
    }
}
