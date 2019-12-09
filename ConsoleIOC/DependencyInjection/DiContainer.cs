using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConsoleIOC.DependencyInjection;

namespace ConsoleIOC.DependencyInjection
{
    public class DiContainer
    {
        private List<ServiceDescriptor> _serviceDescriptors;
        public DiContainer(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        public object GetService(Type serviceType)
        {
            var desciptor = _serviceDescriptors
               .SingleOrDefault(x => x.ServiceType == serviceType);
            if (desciptor.Implementation != null)
            {
                return desciptor.Implementation;
            }

            var actualType = desciptor.ImplementationType ?? desciptor.ServiceType;

            if (actualType.IsAbstract || actualType.IsInterface)
            {
                throw new Exception(message: "Cannot intantiate abstract");
            }

            var constructorInfo = actualType.GetConstructors().First();

            var parameters = constructorInfo.GetParameters()
                .Select(x => GetService(x.ParameterType)).ToArray();

            
            var implementation = Activator
                .CreateInstance(actualType, parameters);

            if (desciptor.Lifetime == ServiceLifeTime.Singleton)
            {
                desciptor.Implementation = implementation;
            }
            return implementation;
        }
        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }
    }
}
