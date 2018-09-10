using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Abp.AppFactory.Interfaces
{
    public interface ISendGridResponse
    {
        HttpStatusCode StatusCode { get; set; }
        HttpContent Body { get; set; }
        HttpResponseHeaders Headers { get; set; }
        Dictionary<string, dynamic> DeserializedResponseBody { get; set; }
        Dictionary<string, string> DeserializedResponseHeaders { get; set; }
    }
}