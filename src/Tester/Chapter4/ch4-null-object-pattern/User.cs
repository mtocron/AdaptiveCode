using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_null_object_pattern
{
    class User : IUser
    {
        public Guid UserId { get; }

        public User(Guid userId)
        {
            UserId = userId;
        }

        public void IncrementSessionTicket()
        {
        }
    }
}
