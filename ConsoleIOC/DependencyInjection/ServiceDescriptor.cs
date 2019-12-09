using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleIOC.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; }

        public Type ImplementationType { get; }
        public object Implementation { get; internal set; }
        public ServiceLifeTime Lifetime { get; }

        public ServiceDescriptor(object implementation, ServiceLifeTime lifetime) 
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifetime;
        }
        public ServiceDescriptor(Type serviceType, ServiceLifeTime lifetime)
        {
            ServiceType = serviceType;
            
            Lifetime = lifetime;
        }

        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifeTime lifetime)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            Lifetime = lifetime;
        }
    }
}
