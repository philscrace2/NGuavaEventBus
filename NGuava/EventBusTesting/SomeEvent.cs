using System;

namespace EventBusTests
{
    public class SomeEvent
    {
        public SomeEvent() { }
        public void UpdateSomeEventValue() {
            Console.WriteLine("Hello World!");
        }
    }
}