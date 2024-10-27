using TaskMvc.Data;
using TaskMvc.Interface.Repository;
using TaskMvc.Models.Entities;

namespace TaskMvc.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(Register register)
        {
            await _context.Registers.AddAsync(register);
            await _context.SaveChangesAsync();
        }
    }
}
