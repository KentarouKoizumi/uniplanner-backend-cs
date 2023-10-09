using Application.Commons;
using Application.DataObjects.ResponseModels.Root;

namespace Application.UseCases.Root.Greeting;

public class GreetingUseCase : IGreetingUseCase
{
    public ExecutionResult<GreetingResponseModel> Execute()
    {
        var result = new ExecutionResult<GreetingResponseModel>();

        var greeting = new GreetingResponseModel
        {
            Message = "Hello, World!"
        };

        result.ResponseModel = greeting;

        return result;
    }
}