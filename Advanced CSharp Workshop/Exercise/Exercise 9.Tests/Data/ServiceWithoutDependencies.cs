using System;

namespace Exercise_9b.Tests.Data
{
    public class ServiceWithoutDependencies : IServiceWithoutDependencies
    {
        public void DoSomething(string test)
        {
            Console.Write(test);
        }
    }
}