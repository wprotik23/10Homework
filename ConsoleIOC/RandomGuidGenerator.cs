using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleIOC
{
    class RandomGuidGenerator
    {
        public Guid RandomGuid { get; set; } = Guid.NewGuid();
    }
}
