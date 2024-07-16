using BlazorComponents;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient(new HttpInterceptorHandle())
//{ 
//    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
//});

builder.Services.AddTransient<HttpInterceptorHandle>();

builder.Services.AddScoped(sp =>
{
    var handler = sp.GetRequiredService<HttpInterceptorHandle>();
    var client = new HttpClient()
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    };
    return client;
});

builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
