using System;

namespace Files
{
    public class FilesException : Exception
    {
        public FilesException(string message, Exception innerException):base(message, innerException)
        {

        }
    }
}
