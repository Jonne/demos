namespace Exercise_9b.Tests.Data
{
    public class ServiceWithPropertyDependency : IServiceWithDependencies
    {
        [Dependency]
        public IServiceWithoutDependencies SomeDependency { get; set; }
    }
}