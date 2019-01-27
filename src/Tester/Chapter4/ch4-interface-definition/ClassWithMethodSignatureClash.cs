using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    public class ClassWithMethodSignatureClash : IInterfaceOne
    {
        public void MethodOne()
        {

        }

        void IInterfaceOne.MethodOne()
        {
        }
    }
}
