using System.Collections.Generic;

namespace Abp.AppFactory.Interfaces
{
    public interface ISendGridResponse : IEmailResponse
    {
        Dictionary<string, dynamic> DeserializedResponseBody { get; set; }
        Dictionary<string, string> DeserializedResponseHeaders { get; set; }
    }
}