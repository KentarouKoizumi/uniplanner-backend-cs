using System.ComponentModel.DataAnnotations;

namespace Application.DataObjects.ResponseModels.Root;

public class GreetingResponseModel
{
    [Required]
    public string Message { get; set; }
}