using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_7.Tests
{
    [TestClass]
    public class ThreadingSpecs
    {
        [TestMethod]
        public void Should_lazily_load_dictionary_and_not_throw_exception()
        {
            var class1 = new StudentRegistry();

            // Implement this spec that proves that the lazy property is not thread safe. 
            // Don't use the new TPL stuff yet (Task), use normal threads or threadpool
            // After this fix the race condition.
        }
    }
}