using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Blazor.FastComponents.Components
{
    public abstract class FastComponentBase : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}
