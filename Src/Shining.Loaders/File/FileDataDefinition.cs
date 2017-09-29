using System;

namespace Shining.Loaders.File
{
    public class FileDataDefinition : AbstractDataDefinition
    {
        public static readonly String PREFIX = "file://";
        public FileDataDefinition(string dataDescription) : base(dataDescription)
        {
            if (IsValid() == false) return;

            Path = _dataDescription.Substring(PREFIX.Length);
        }

        public bool IsValid()
        {
            return String.IsNullOrEmpty(_dataDescription) == false && 
                _dataDescription.StartsWith(PREFIX, StringComparison.InvariantCultureIgnoreCase);
        }

        public String Path { get; set; }
    }
}