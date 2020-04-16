using BlogWebAPI.Filters.CustomExceptions;
using BlogWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace BlogWebAPI.Filters
{
    public class CustomExeptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is HttpResponseException)
            {
                var httpResponseException = actionExecutedContext.Exception as HttpResponseException;

                if (httpResponseException.Response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return;
                }
            }

            var exception = actionExecutedContext.Exception as ApiException;
            var code = exception?.ErrorCodes ?? Enums.ErrorCodes.General;

            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.OK, new BaseResponse
            {
                ErrorCode = code,
                Message = exception.Message,
                InternalMessage = actionExecutedContext.Exception.Message
            },

            actionExecutedContext.ActionContext.ControllerContext.Configuration.Formatters.JsonFormatter);
        }
    }
}