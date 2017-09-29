using System;
using System.IO;

namespace Shining.Loaders.File
{
    public class FileLoader : AbstractDataLoader
    {
        public static readonly FileLoader Instance = new FileLoader();
        private FileLoader()
        {

        }
        public override Stream LoadFromDescription(string dataDescription)
        {
            var def = new FileDataDefinition(dataDescription);
            if (def.IsValid() == false) throw new Exception("File definition is invalid!");

            return System.IO.File.OpenRead(def.Path);
        }
    }
}