using System;
//using ConsoleIOC.DependencyInjection;

namespace ConsoleIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var services = new DiserviceCollection();

            //services.RegisterSingleton<RandomGuidGenerator>();
            //services.RegisterTransient<RandomGuidGenerator>();
            services.RegisterTransient<ISomeService, SomeServiceOne>();
            services.RegisterTransient<IRandomGuidProvider, RandomGuidProvider>();

            var container = services.GenerateContainer();
                      
            
            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();

            serviceFirst.PrintSomething();
            serviceSecond.PrintSomething();
        }
    }
}
