﻿using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_4.Tests
{
    [TestClass]
    public class MapSpecs
    {
        [TestMethod]
        public void SimpleProjectionToDifferentType()
        {
            int[] source = {1, 5, 2};
            var result = source.Select(x => x.ToString());
            result.Should().Equal(new []{"1", "5", "2"});
        }
        
        [TestMethod]
        public void ExecutionIsDeferred()
        {
            ThrowingEnumerable.AssertDeferred(src => src.Select(x => x > 0));
        }
    }
}