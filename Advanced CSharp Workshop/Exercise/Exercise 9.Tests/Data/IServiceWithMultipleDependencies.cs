namespace Exercise_9b.Tests.Data
{
    public interface IServiceWithMultipleDependencies
    {
        IServiceWithoutDependencies Dependency1 { get; set; }
        IServiceWithDependencies Dependency2 { get; set; }
    }
}