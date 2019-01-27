using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    public class ExplicitInterfaceClient
    {
        public ExplicitInterfaceClient
            (
            ExplicitInterfaceImplementation implementationReference
            , ISimpleInterface interfaceReference
            )
        {
            // implementationReferenceではコンパイツエラーになる

            var interfaceProperyValue = interfaceReference.ThisIntegerPropertyOnlyNeedGetter;
            interfaceReference.ThisMethodRequiresImplementation();
            interfaceReference.ThisStringPropertyNeedImplementingToo = "Hello";
            interfaceReference.InterfacesCanContainEventsToo += EventHandler;
        }

        void EventHandler(object sender, EventArgs e)
        {

        }
    }
}
