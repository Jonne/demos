namespace Exercise_9b.Tests.Data
{
    public class ServiceWithDependencies : IServiceWithDependencies
    {
        public ServiceWithDependencies(IServiceWithoutDependencies dependency)
        {
            SomeDependency = dependency;
        }

        public IServiceWithoutDependencies SomeDependency { get; set; }
    }
}