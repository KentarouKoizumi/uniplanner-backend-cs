using Application.Commons;
using Application.DataObjects.ResponseModels.Root;

namespace Application.UseCases.Root.Greeting;

public interface IGreetingUseCase
{
    ExecutionResult<GreetingResponseModel> Execute();
}