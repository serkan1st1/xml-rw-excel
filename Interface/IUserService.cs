using TaskMvc.Models.Entities;

namespace TaskMvc.Interface
{
    public interface IUserService
    {
        Task RegisterUserAsync(Register model, IFormFile profileImage);
    }
}
