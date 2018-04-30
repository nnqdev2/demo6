using System;

namespace OlprrApi.Common.Exceptions
{
    public class StoreProcedureNonZeroOutputParamException : Exception
    {
        public StoreProcedureNonZeroOutputParamException() : base() { }
        public StoreProcedureNonZeroOutputParamException(string message) : base(message) { }
        public StoreProcedureNonZeroOutputParamException(string message, Exception inner) : base(message, inner) { }
    }
}
