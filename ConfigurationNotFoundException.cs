using System;
using System.Runtime.Serialization;

namespace FunctionalTests_AutomationPracticeCom
{
    [Serializable]
    internal class ConfigurationNotFoundException : Exception
    {
        public ConfigurationNotFoundException()
        {
        }

        public ConfigurationNotFoundException(string message) : base(message)
        {
        }

        public ConfigurationNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConfigurationNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}