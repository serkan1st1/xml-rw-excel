using TaskMvc.Models.DTOs;

namespace TaskMvc.Interface
{
    public interface IFileSaveService
    {
        Task<SBIFDTOs> DeserializeXmlAsync(string filePath);
    }
}
