using System;

namespace CQRS.Stas.Containers
{
    public interface IContainer
    {
        object Resolve(Type type);
        void Release(object obj);
    }
}