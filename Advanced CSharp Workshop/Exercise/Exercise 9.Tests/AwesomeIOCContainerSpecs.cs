﻿using System;
using Exercise_9b.Tests.Data;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_9b.Tests
{
    [TestClass]
    public class AwesomeIOCContainerSpecs
    {
        [TestMethod]
        public void Should_throw_when_resolving_unknown_type()
        {
            var container = new MyAwesomeIocContainer();

            Action action = () => container.Resolve<IServiceWithoutDependencies>();
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void Should_instantiate_simple_registered_type()
        {
            var container = new MyAwesomeIocContainer();
            container.Register<IServiceWithoutDependencies, ServiceWithoutDependencies>();

            var implementation = container.Resolve<IServiceWithoutDependencies>();
            implementation.Should().NotBeNull();
            implementation.Should().BeOfType<ServiceWithoutDependencies>();
        }

        [TestMethod]
        public void Should_instantiate_registered_type_with_dependency()
        {
            var container = new MyAwesomeIocContainer();

            container.Register<IServiceWithoutDependencies, ServiceWithoutDependencies>();
            container.Register<IServiceWithDependencies, ServiceWithDependencies>();

            var implementation = container.Resolve<IServiceWithDependencies>();
            implementation.Should().NotBeNull();
            implementation.Should().BeOfType<ServiceWithDependencies>();

            implementation.SomeDependency.Should().NotBeNull();
            implementation.SomeDependency.Should().BeOfType<ServiceWithoutDependencies>();
        }

        [TestMethod]
        public void Should_instantiate_registered_type_with_property_dependency()
        {
            var container = new MyAwesomeIocContainer();

            container.Register<IServiceWithoutDependencies, ServiceWithoutDependencies>();
            container.Register<IServiceWithDependencies, ServiceWithPropertyDependency>();

            var implementation = container.Resolve<IServiceWithDependencies>();
            implementation.Should().NotBeNull();
            implementation.Should().BeOfType<ServiceWithPropertyDependency>();

            implementation.SomeDependency.Should().NotBeNull();
            implementation.SomeDependency.Should().BeOfType<ServiceWithoutDependencies>();
        }        
        [TestMethod]
        public void Should_instantiate_registered_type_with_multiple_dependencies()
        {
            var container = new MyAwesomeIocContainer();

            container.Register<IServiceWithoutDependencies, ServiceWithoutDependencies>();
            container.Register<IServiceWithDependencies, ServiceWithDependencies>();
            container.Register<IServiceWithMultipleDependencies, ServiceWithMultipleDependencies>();

            var implementation = container.Resolve<IServiceWithMultipleDependencies>();
            implementation.Should().NotBeNull();
            implementation.Should().BeOfType<ServiceWithMultipleDependencies>();

            implementation.Dependency1.Should().NotBeNull();
            implementation.Dependency1.Should().BeOfType<ServiceWithoutDependencies>();
            
            implementation.Dependency2.Should().NotBeNull();
            implementation.Dependency2.Should().BeOfType<ServiceWithDependencies>();
        }

        [TestMethod]
        public void Should_instantiate_registered_type_with_nested_dependencies()
        {
            var container = new MyAwesomeIocContainer();

            container.Register<IServiceWithoutDependencies, ServiceWithoutDependencies>();
            container.Register<IServiceWithDependencies, ServiceWithDependencies>();
            container.Register<IServiceWithMultipleDependencies, ServiceWithMultipleDependencies>();

            var implementation = container.Resolve<IServiceWithMultipleDependencies>();
            implementation.Should().NotBeNull();
            implementation.Should().BeOfType<ServiceWithMultipleDependencies>();
            
            implementation.Dependency2.Should().NotBeNull();
            implementation.Dependency2.Should().BeOfType<ServiceWithDependencies>();

            implementation.Dependency2.SomeDependency.Should().NotBeNull();
            implementation.Dependency2.SomeDependency.Should().BeOfType<ServiceWithoutDependencies>();
        }

        [TestMethod]
        public void Should_instantiate_registered_type_with_factory_dependency()
        {
            var container = new MyAwesomeIocContainer();
            var serviceInstance = new ServiceWithoutDependencies();
            container.Register<IServiceWithoutDependencies>(c => serviceInstance);

            var implementation = container.Resolve<IServiceWithoutDependencies>();
            
            implementation.Should().Be(serviceInstance);
        }

        [TestMethod]
        public void Should_resolve_registered_instance()
        {
            var container = new MyAwesomeIocContainer();

            var serviceInstance = new ServiceWithoutDependencies();

            container.Register<IServiceWithoutDependencies>(serviceInstance);

            var implementation = container.Resolve<IServiceWithoutDependencies>();
            implementation.Should().Be(serviceInstance);
        }

        [TestMethod]
        public void Should_auto_register()
        {
            var container = new MyAwesomeIocContainer();

            container.RegisterAll<IServiceWithoutDependencies>(type => type.FullName.Contains("Service"));

            container.Resolve<IServiceWithoutDependencies>().Should().BeOfType<ServiceWithoutDependencies>();
            container.Resolve<IServiceWithDependencies>().Should().BeOfType<ServiceWithDependencies>();
            container.Resolve<IServiceWithMultipleDependencies>().Should().BeOfType<ServiceWithMultipleDependencies>();
        }
        
    }
}