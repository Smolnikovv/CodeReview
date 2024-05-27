using CodeReview.Config;

namespace CodeReview.Services
{
    public interface IUserService
    {
        public Task<bool> Delete(uint id);
    }
    public class UserService : IUserService
    {
        private readonly Context _context;

        public UserService(Context context)
        {
            _context = context;
        }

        public async Task<bool>  Delete(uint id)
        {
            var user = await _context.Users.FindAsync(id);
            
            if (user != null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
