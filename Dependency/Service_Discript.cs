using System;
namespace Dependency
{
    internal class Service_Discript
    {
        public Type ServiceType { get; private set; }
        public Type ImplementType { get; private set; }
        public object Implementation { get; set; }
        public ServiceLifeTime LifeTime { get; private set; }


        public Service_Discript(Type serviceType, Type implementType, ServiceLifeTime lifetime)
        {
            ServiceType = serviceType;
            ImplementType = implementType;
            LifeTime = lifetime;
        }
    }

    public enum ServiceLifeTime
    {
        Singletone,
        Transient
    }
}