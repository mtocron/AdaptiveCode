using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    public class ExplicitInterfaceImplementation : ISimpleInterface
    {
        public ExplicitInterfaceImplementation()
        {
            _EncapselatedInteger = 4;
        }

        // 明示的に実装されたインタフェースのメソッドは
        // クラスのインスタンスのではなく、インタフェースのインスタンスへの参照が必要

        string ISimpleInterface.ThisStringPropertyNeedImplementingToo { get; set; }

        int ISimpleInterface.ThisIntegerPropertyOnlyNeedGetter => _EncapselatedInteger;

        event EventHandler<EventArgs> ISimpleInterface.InterfacesCanContainEventsToo
        {
            add
            {
                _EncapselatedEvent += value;
            }

            remove
            {
                _EncapselatedEvent -= value;
            }
        }

        void ISimpleInterface.ThisMethodRequiresImplementation()
        {
            _EncapselatedEvent?.Invoke(this, EventArgs.Empty);
        }

        private int _EncapselatedInteger;
        private event EventHandler<EventArgs> _EncapselatedEvent;
    }
}
