using System;

namespace Exercise_9
{
    public class MyAwesomeIocContainer
    {
        public void Register<T, T1>()
        {
            throw new NotImplementedException();
        }

        public void Register<T>(T instance)
        {
            throw new NotImplementedException();
        }

        public void Register<T>(Func<MyAwesomeIocContainer, object> factory)
        {
            throw new NotImplementedException();
        }

        public T Resolve<T>()
        {
            throw new NotImplementedException();
        }

        public object Resolve(Type type)
        {
            throw new NotImplementedException();
        }

        public void RegisterAll<T>(Func<Type, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}