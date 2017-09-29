using System;
using Xunit;
using Shining.Loaders;
using Shining.Loaders.File;

namespace Shining.Loaders.Tests
{
    public class DataDescriptionTests
    {
        [Fact]
        public void FileDataTest()
        {
            var des = new FileDataDefinition("file://c:/test.txt");
            Assert.Equal<String>("c:/test.txt", des.Path);
        }
    }
}