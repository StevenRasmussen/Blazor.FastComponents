using Microsoft.AspNetCore.Components;

namespace Blazor.FastComponents.Components
{
    partial class FastDesignSystemProvider
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
