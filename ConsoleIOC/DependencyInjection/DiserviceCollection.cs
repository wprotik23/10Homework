using ConsoleIOC.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleIOC
{
    class DiserviceCollection
    {
        private List<ServiceDescriptor> _ServiceDescriptors = new List<ServiceDescriptor>();

        

        public void RegisterSingleton<TService>(TService implemenation)
        {

            _ServiceDescriptors.Add(item: new ServiceDescriptor(implemenation, ServiceLifeTime.Singleton));
        }

        public void RegisterSingleton<TService>()
        {

            _ServiceDescriptors.Add(item: new ServiceDescriptor(typeof(TService), ServiceLifeTime.Singleton));
        }

        public void RegisterTransient<TService>()
        {

            _ServiceDescriptors.Add(item: new ServiceDescriptor(typeof(TService), ServiceLifeTime.Transient));
        }

        public void RegisterTransient<TService, TImplementation>()
        {

            _ServiceDescriptors.Add(item: new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifeTime.Transient));
        }
        public DiContainer GenerateContainer()
        {
            return new DiContainer(_ServiceDescriptors);
        }
    }
}
