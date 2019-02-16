using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_null_object_pattern
{
    interface IUserRepository
    {
        IUser GetUserById(Guid userId);
    }
}
