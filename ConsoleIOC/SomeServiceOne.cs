using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleIOC
{
    public class SomeServiceOne : ISomeService
    {
        //private readonly Guid RandomGuid = Guid.NewGuid();
        private readonly IRandomGuidProvider _randomGuidProvider;
        public SomeServiceOne(IRandomGuidProvider randomGuidProvider)
        {
            _randomGuidProvider = randomGuidProvider;
        }

        public void PrintSomething() 
        {
            Console.WriteLine(_randomGuidProvider.RandomGuid);
        }
    }
}
