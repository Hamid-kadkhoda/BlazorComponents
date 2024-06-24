
namespace BlazorComponents.Models.Common
{
    public class TooltipOption
    {
        /// <summary>
        /// Label of tooltip.
        /// </summary>
        public string? TooltipLabel { get; set; }

        /// <summary>
        /// Position of tooltip.
        /// </summary>
        public TooltipPosition? TooltipPosition { get; set; }

        /// <summary>
        /// Event to show the tooltip.
        /// </summary>
        public TooltipEvent? TooltipEvent { get; set; }

        /// <summary>
        /// Target element to attach the overlay.
        /// </summary>
        public object AppendTo { get; set; } = "body";

        /// <summary>
        /// Type of CSS position.
        /// </summary>
        public string? PositionStyle { get; set; }

        /// <summary>
        /// Style class of the tooltip.
        /// </summary>
        public string? TooltipStyleClass { get; set; }

        /// <summary>
        /// Whether the z-index should be managed automatically to always go on top or have a fixed value.
        /// </summary>
        public string? TooltipZIndex { get; set; } = "auto";

        /// <summary>
        /// By default the tooltip contents are rendered as text. Set to false to support html tags in the content.
        /// </summary>
        public bool? Escape { get; set; }

        /// <summary>
        /// When present, it specifies that the component should be disabled.
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Specifies the additional vertical offset of the tooltip from its default position.
        /// </summary>
        public int? PositionTop { get; set; }

        /// <summary>
        /// Specifies the additional horizontal offset of the tooltip from its default position.
        /// </summary>
        public int? PositionLeft { get; set; }

        /// <summary>
        /// Delay to show the tooltip in milliseconds.
        /// </summary>
        public int? ShowDelay { get; set; }

        /// <summary>
        /// Delay to hide the tooltip in milliseconds.
        /// </summary>
        public int? HideDelay { get; set; }

        /// <summary>
        /// Time to wait in milliseconds to hide the tooltip even it is active.
        /// </summary>
        public int? Life { get; set; }

        /// <summary>
        /// When present, it adds a custom id to the tooltip.
        /// </summary>
        public string? Id { get; set; }
    }

    public enum TooltipPosition
    {
        Right,
        Left,
        Top,
        Bottom
    }

    public enum TooltipEvent
    {
        Hover,
        Focus
    }
}
