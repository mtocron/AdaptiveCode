using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    // クラスの多重継承の概念はサポートされていないが
    // １つのクラスで複数のインターフェイスを実装することが可能
    public class InmplementingMultipleInterfaces : IInterfaceOne, IInterfaceTwo
    {
        public void MethodOne()
        {
        }

        public void MethodTwo()
        {
        }
    }
}
