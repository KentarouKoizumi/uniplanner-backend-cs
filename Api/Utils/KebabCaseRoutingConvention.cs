using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Api.Utils;


public class KebabCaseRoutingConvention : Attribute, IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        controller.ControllerName = ConvertToKebabCase(controller.ControllerName);

        foreach (var action in controller.Actions)
        {
            action.ActionName = ConvertToKebabCase(action.ActionName);
        }
    }

    private static string ConvertToKebabCase(string input)
    {
        return string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? "-" + x.ToString() : x.ToString())).ToLower();

    }
}
