using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BookStore.Communication.Responses; // <--- 1. Importe o namespace da sua classe

namespace BookStore.API.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is ArgumentException)
        {
            var responseJson = new ResponseErrorsJson();

            // Truque: Se tiver ";", a gente quebra em várias mensagens. 
            // Se não tiver, vira uma lista com 1 item só.
            responseJson.Errors = context.Exception.Message.Split("; ").ToList();

            context.Result = new BadRequestObjectResult(responseJson);
            context.ExceptionHandled = true;
        }
    }
}