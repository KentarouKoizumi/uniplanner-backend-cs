namespace Application.UseCases.Root.Greeting;

public class GreetingUseCase : IGreetingUseCase
{
    public string Execute()
    {
        return "Hello World!";
    }
}