using System;

namespace CQRS.IRR.DependencyResolver
{
    public interface IDependencyResolver
    {
        object Resolve(Type serviceType);

        object Resolve(Type serviceType, string name);

        T Resolve<T>();

        T Resolve<T>(string name);

        T[] ResolveAll<T>();

        Array ResolveAll(Type serviceType);
    }
}
