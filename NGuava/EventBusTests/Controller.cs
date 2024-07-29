using NGuava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusTests
{
    public  class Controller
    {
        public Controller(IEventBus eventBus)
        {
            eventBus.Register(this);
        }

        [Subscribe]
        public void OnDoSomeThing(SomeEvent evnt)
        {
            evnt.UpdateSomeEventValue();
        }
    }
}
