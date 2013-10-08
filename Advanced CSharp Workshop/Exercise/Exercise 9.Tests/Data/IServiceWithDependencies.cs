namespace Exercise_9b.Tests.Data
{
    public interface IServiceWithDependencies
    {
        IServiceWithoutDependencies Dependency { get; set; }
    }
}