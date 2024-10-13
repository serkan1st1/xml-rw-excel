using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using TaskMvc.Interface;

namespace TaskMvc.Business
{
    public class FileUploadService: IFileUploadService
    {
        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "uploads", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return path;
        }
    }
}
