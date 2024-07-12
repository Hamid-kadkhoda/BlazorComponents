using Microsoft.AspNetCore.Components;

namespace BlazorUIComponents.Components.Base
{
    public partial class BlazorComponent: ComponentBase
    {
        [Parameter] public string? Style { get; set; }

        [Parameter] public string? StyleClass { get; set; }

        [Parameter] public RenderFragment? ChildContent { get; set; }
    }
}
