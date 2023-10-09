using System.Diagnostics;
using System.Net;

namespace Application.Commons;
public class ExecutionResult
{
    public ExecutionError? Error { get; private set; }

    public ExecutionResult SetAsBadRequest(string message)
    {
        Error = new ExecutionError
        {
            Title = "Bad Request",
            Code = (int)HttpStatusCode.BadRequest,
            Message = message,
            TraceId = Activity.Current?.Id ?? ""
        };

        return this;
    }

    public ExecutionResult SetAsNotFound(string message)
    {
        Error = new ExecutionError
        {
            Title = "Not Found",
            Code = (int)HttpStatusCode.NotFound,
            Message = message,
            TraceId = Activity.Current?.Id ?? ""
        };

        return this;
    }

    public ExecutionResult SetAsCustomError(string title, int code, string message)
    {
        Error = new ExecutionError
        {
            Title = title,
            Code = code,
            Message = message,
            TraceId = Activity.Current?.Id ?? ""
        };

        return this;
    }
}

public class ExecutionResult<T> : ExecutionResult
{
    public T ResponseModel { get; set; }

    public ExecutionResult() { }

}