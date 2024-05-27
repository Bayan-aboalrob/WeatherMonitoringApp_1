using System;
using System.Runtime.Serialization;

namespace WeatherMonitoringApp
{
    [Serializable]
    public class EmptyFileException : Exception
    {
        public string FilePath { get; }

        public EmptyFileException() { }

        public EmptyFileException(string message) : base(message) { }

        public EmptyFileException(string message, string filePath) : base(message)
        {
            FilePath = filePath;
        }

        public EmptyFileException(string message, string filePath, Exception innerException) : base(message, innerException)
        {
            FilePath = filePath;
        }

        protected EmptyFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info != null)
            {
                FilePath = info.GetString("FilePath");
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            if (info != null)
            {
                info.AddValue("FilePath", FilePath);
            }
        }
    }
}
