using System;
using System.IO;

namespace Shining.Loaders
{
    public interface IDataLoader
    {
        Stream LoadFromDescription(String dataDescription);
    }
}