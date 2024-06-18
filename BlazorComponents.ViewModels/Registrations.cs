using Microsoft.Extensions.DependencyInjection;

namespace BlazorComponents.ViewModels
{
    public static class Registrations
    {
        public static void AddViewModels(this IServiceCollection services)
        {
            services.AddScoped<DataGridViewModel>();
        }
    }
}
