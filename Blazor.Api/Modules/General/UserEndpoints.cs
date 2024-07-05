using FastEndpoints;

namespace Blazor.Api.Modules.General
{
    public class MyEndpoint : Endpoint<MyRequest, MyResponse>
    {
        public override void Configure()
        {
            Post("/hello/world");
            AllowAnonymous();
        }

        public override async Task HandleAsync(MyRequest r, CancellationToken c)
        {
            await SendAsync(new()
            {
                FullName = $"{r.FirstName} {r.LastName}",
                Message = "Welcome to FastEndpoints..."
            });
        }
    }

    public class MyRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MyResponse
    {
        public string FullName { get; set; }
        public string Message { get; set; }
    }
}
