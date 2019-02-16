using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_null_object_pattern
{
    class UserRepository : IUserRepository
    {
        private IEnumerable<User> _LiseUser;

        public UserRepository()
        {
            _LiseUser = new List<User>
            {
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
            };
        }

        public IUser GetUserById(Guid userId)
        {
            IUser user = _LiseUser.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
            {
                user = new NullUser();
            }

            return user;
        }
    }
}
