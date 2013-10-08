namespace Exercise_9b.Tests.Data
{
    public class ServiceWithDependencies : IServiceWithDependencies
    {
        public ServiceWithDependencies(IServiceWithoutDependencies dependency)
        {
            Dependency = dependency;
        }

        public IServiceWithoutDependencies Dependency { get; set; }
    }
}