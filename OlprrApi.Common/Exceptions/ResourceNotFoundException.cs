using System;
using System.Collections.Generic;
using System.Text;

namespace OlprrApi.Common.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException() : base() { }
        public ResourceNotFoundException(string message) : base(message) { }
        public ResourceNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
