using System;
using System.IO;
using System.Collections.Generic;

using Shining.Loaders.File;

namespace Shining.Loaders
{
    public abstract class AbstractDataLoader : IDataLoader
    {
        public static Stream Load(String dataDescription)
        {
            if (dataDescription.StartsWith(FileDataDefinition.PREFIX, StringComparison.InvariantCultureIgnoreCase)) 
                return FileLoader.Instance.LoadFromDescription(dataDescription);

            throw new NotImplementedException();
        }

        public abstract Stream LoadFromDescription(string dataDescription);
    }
}