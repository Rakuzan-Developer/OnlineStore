using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace OnlineStore.ServiceHost.API.Handlers
{
    public class ApiResponseHandler : DelegatingHandler
    {

        protected override async System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            System.Threading.CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            return BuildApiResponse(request, response);
        }

        private HttpResponseMessage BuildApiResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
            object content = null;
            string errorMessage = string.Empty;
        }

        private void ValidateApiResponse(HttpResponseMessage response, ref object content, ref string errorMessage)
        {

        }


    }
}