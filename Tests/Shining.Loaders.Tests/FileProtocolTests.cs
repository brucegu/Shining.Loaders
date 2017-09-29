using System;
using Xunit;
using Shining.Loaders;

namespace Shining.Loaders.Tests
{
    public class FileProtocolTests
    {
        [Fact]
        public void FileLoaderTest()
        {
            var stream = AbstractDataLoader.Load("file://c:/test.txt");
            Assert.NotEqual(stream, null);
        }
    }
}