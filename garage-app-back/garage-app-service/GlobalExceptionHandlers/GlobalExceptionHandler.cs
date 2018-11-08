using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace garage_app_service.GlobalExceptionHandlers
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            Debug.WriteLine("+++++++++++++++++ EXCEPTION +++++++++++++++++");
            Debug.WriteLine(context.Exception.Message);
            Debug.WriteLine(context.Exception.StackTrace);
            if (context.Exception is NullReferenceException)
            {
                var result = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("please us the correct format for this endpoint"),
                    ReasonPhrase = context.Exception.Message
                };

                context.Result = new CustomActionResult(context.Request, result);
                return Task.FromResult(result);
            }
            else if (context.Exception is ArgumentException)
            {
                var result = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(context.Exception.Message),
                    ReasonPhrase = "bad Arguments"
                };

                context.Result = new CustomActionResult(context.Request, result);
                return Task.FromResult(result);
            }
            else
            {
                var result = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(context.Exception.Message),
                    ReasonPhrase = "oops, something bad happened"
                };

                context.Result = new CustomActionResult(context.Request, result);
                return Task.FromResult(result);
            }
        }

        private class CustomActionResult : IHttpActionResult
        {
            private HttpRequestMessage _request;
            private readonly HttpResponseMessage _httpResponseMessage;


            public CustomActionResult(HttpRequestMessage request, HttpResponseMessage httpResponseMessage)
            {
                _request = request;
                _httpResponseMessage = httpResponseMessage;
            }

            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {
                return Task.FromResult(_httpResponseMessage);
            }
        }
    }
}