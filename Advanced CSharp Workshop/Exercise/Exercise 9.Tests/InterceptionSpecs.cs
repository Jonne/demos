using Exercise_9b.Tests.Data;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_9b.Tests
{
    [TestClass]
    public class InterceptionSpecs
    {
        [TestMethod]
        public void Should_intercept_method_call()
        {
            var container = new MyAwesomeIocContainer();

            var testInterceptor = new TestInterceptor();
            container.InterceptWith(testInterceptor);

            container.Register<IServiceWithoutDependencies, ServiceWithoutDependencies>();

            var service = container.Resolve<IServiceWithoutDependencies>();

            service.DoSomething("bla");

            testInterceptor.HasIntercepted.Should().BeTrue();
        }
    }

    public class TestInterceptor : IIntercept
    {
        public bool HasIntercepted = false;

        public void OnIntercept()
        {
            HasIntercepted = true;
        }
    }
}