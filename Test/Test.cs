using NUnit.Framework;
using System;
namespace Test
{
    [TestFixture()]
    public class Test
    {
        [TestCase]
        public void Vending_machine_is_a_class()
        {
            var machine = new VendingMachine();
        }
    }
}
