using System.Collections.Generic;
using System.Linq;

namespace register_and_login_page.Services
{
    public class UserService
    {
        private readonly R_LDbContext _context;

        public UserService(R_LDbContext context)
        {
            _context = context;
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
