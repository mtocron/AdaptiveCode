using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_adapter_pattern
{
    public class ObjectAdapter : IExpectedInterface
    {
        private TargetClass _Target;

        public ObjectAdapter(TargetClass target)
        {
            _Target = target;
        }

        public void MethodA()
        {
            _Target.MethodB();
        }
    }
}
