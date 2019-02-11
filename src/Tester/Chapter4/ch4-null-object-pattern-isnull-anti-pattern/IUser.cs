using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_null_object_pattern_isnull_anti_pattern
{
    interface IUser
    {
        void IncrementSessionTicket();

        string Name { get; }

        bool IsNull { get; }
    }
}
