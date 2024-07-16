
using Microsoft.AspNetCore.Components;

namespace BlazorUIComponents.Components.Base
{
    public class DisposableBlazorComponent: BlazorComponent
    {
        [Parameter] public bool Visibility { get; set; }

        [Parameter] public EventCallback<bool> VisibilityChanged { get; set; }
    }
}
