
namespace BlazorComponents
{
    public class HttpInterceptorHandle : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("X-MyTestHeader", "MyValue");  // Add whatever headers you want here

            return base.SendAsync(request, cancellationToken);
        }
    }
}
