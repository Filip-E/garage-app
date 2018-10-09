using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using garage_app_entities;

namespace DAL.Repositories
{
    public class UserRepository
    {
        private MyDbContext _context;

        public UserRepository(MyDbContext context)
        {
            _context = context;
        }

        public User FindUser(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User FindUserByUserName(string userName)
        {
            return _context.Users.First(user => user.UserName == userName);
        }
    }
}
