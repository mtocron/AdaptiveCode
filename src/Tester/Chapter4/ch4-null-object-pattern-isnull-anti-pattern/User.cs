using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_null_object_pattern_isnull_anti_pattern
{
    class User : IUser
    {
        private DateTime _SessionExpiry = DateTime.Now;

        public string Name { get; private set; }

        public bool IsNull => false;

        public Guid UserId { get; }

        public User(Guid userId)
        {
            UserId = userId;
        }

        public void IncrementSessionTicket()
        {
            _SessionExpiry.AddMinutes(30);
        }
    }
}
