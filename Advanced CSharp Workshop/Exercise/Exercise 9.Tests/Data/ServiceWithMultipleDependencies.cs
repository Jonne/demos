namespace Exercise_9b.Tests.Data
{
    public class ServiceWithMultipleDependencies : IServiceWithMultipleDependencies
    {
        public ServiceWithMultipleDependencies(IServiceWithoutDependencies dependency1, IServiceWithDependencies dependency2)
        {
            Dependency1 = dependency1;
            Dependency2 = dependency2;
        }

        public IServiceWithoutDependencies Dependency1 { get; set; }
        public IServiceWithDependencies Dependency2 { get; set; }
    }
}