using System;

namespace Shining.Loaders
{
    public abstract class AbstractDataDefinition
    {
        protected String _dataDescription = String.Empty;
        public AbstractDataDefinition(String dataDescription)
        {
            _dataDescription = dataDescription;
        }
    }
}