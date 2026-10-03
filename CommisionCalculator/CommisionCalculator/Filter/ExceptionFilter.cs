using CommisionCalculator.Communication.Responses;
using CommisionCalculator.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CommisionCalculator.Filter
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is CommisionException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnknownError(context);
            }
        }

        private void HandleProjectException(ExceptionContext context) 
        {
            var commisionException = (CommisionException)context.Exception;
            var errorResponse =  new ResponseError(commisionException.GetErros());
            context.HttpContext.Response.StatusCode = commisionException.StatusCode;
            context.Result = new ObjectResult(errorResponse);
        }

        private void ThrowUnknownError(ExceptionContext context)
        {
            var errorResponse = new ResponseError(["erroDesconhecido"]);
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorResponse);
        }
    }
}
