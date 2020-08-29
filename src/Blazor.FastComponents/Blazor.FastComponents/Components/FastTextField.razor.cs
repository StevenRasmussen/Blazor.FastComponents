using Microsoft.AspNetCore.Components;

namespace Blazor.FastComponents.Components
{
    public partial class FastTextField : FastComponentBase
    {
        [Parameter] public bool AutoFocus { get; set; } = false;
        [Parameter] public bool ReadOnly { get; set; } = false;
        [Parameter] public string? PlaceHolder { get; set; }
        [Parameter] public bool Required { get; set; } = false;
        [Parameter] public string? Value { get; set; }
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public string? List { get; set; }
        [Parameter] public int? MinLength { get; set; }
        [Parameter] public int? MaxLength { get; set; }
        [Parameter] public string? Name { get; set; }
        [Parameter] public string? Pattern { get; set; }
        [Parameter] public int? Size { get; set; }
        [Parameter] public bool SpellCheck { get; set; }
        [Parameter] public TextFieldType TextFieldType { get; set; } = TextFieldType.text;
        [Parameter] public AppearanceType Appearance { get; set; } = AppearanceType.outline;
    }
}
