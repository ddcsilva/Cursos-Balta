using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Extensions;

public static class ModelStateExtensions
{
    public static List<string> ObterErros(this ModelStateDictionary modelState)
    {
        var resultado = new List<string>();

        foreach (var value in modelState.Values)
        {
            resultado.AddRange(value.Errors.Select(error => error.ErrorMessage));
        }

        return resultado;
    }
}