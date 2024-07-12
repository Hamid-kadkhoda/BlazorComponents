using Microsoft.AspNetCore.Components;

namespace BlazorUIComponents.Components.Base
{
    public class BlazorBaseInput: BlazorComponent
    {
        [Parameter] public string? Value { get; set; }

        [Parameter] public string? Placeholder { get; set; }

        [Parameter] public EventCallback<string>? ValueChanged { get; set; }
    }
}
