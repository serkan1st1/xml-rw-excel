using TaskMvc.Models.Entities;

namespace TaskMvc.Interface.Repository
{
    public interface IUserRepository
    {
        Task AddUserAsync(Register register);
    }
}
