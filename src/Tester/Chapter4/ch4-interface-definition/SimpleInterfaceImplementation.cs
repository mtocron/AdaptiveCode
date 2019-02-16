using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    public class SimpleInterfaceImplementation : ISimpleInterface
    {
        public string ThisStringPropertyNeedImplementingToo { get; set; }

        public int ThisIntegerPropertyOnlyNeedGetter
        {
            get { return _EncapsulatedInteger; }
            set { _EncapsulatedInteger = value; }
        }

        public event EventHandler<EventArgs> InterfacesCanContainEventsToo;

        public void ThisMethodRequiresImplementation()
        {
        }

        private int _EncapsulatedInteger;
    }
}
