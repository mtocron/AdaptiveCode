using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    public interface ISimpleInterface
    {
        void ThisMethodRequiresImplementation();

        string ThisStringPropertyNeedImplementingToo { get; set; }

        int ThisIntegerPropertyOnlyNeedGetter { get; }

        event EventHandler<EventArgs> InterfacesCanContainEventsToo;
    }
}
