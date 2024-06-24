
namespace BlazorComponents.Models.Common
{
    public class MenuItem
    {
        // Text of the item
        public string? Label { get; set; }

        // Icon of the item
        public string? Icon { get; set; }

        // Callback to execute when item is clicked
        public Action? Command { get; set; }
        //public Action<MenuItemCommandEvent?>? Command { get; set; }

        // External link to navigate when item is clicked
        public string? Url { get; set; }

        // An array of children menuitems
        public List<MenuItem>? Items { get; set; }

        // Visibility of submenu
        public bool? Expanded { get; set; }

        // When set as true, disables the menuitem
        public bool? Disabled { get; set; }

        // Whether the dom element of menuitem is created or not
        public bool? Visible { get; set; }

        // Specifies where to open the linked document
        public string? Target { get; set; }

        // Whether to escape the label or not. Set to false to display html content
        public bool? Escape { get; set; }

        // Configuration for active router link
        public object? RouterLinkActiveOptions { get; set; }

        // Defines the item as a separator
        public bool? Separator { get; set; }

        // Value of the badge
        public string? Badge { get; set; }

        // Tooltip of the item
        public string? Tooltip { get; set; }

        // Position of the tooltip item
        public string? TooltipPosition { get; set; }

        // Style class of the badge
        public string? BadgeStyleClass { get; set; }

        // Inline style of the menuitem
        public Dictionary<string, object>? Style { get; set; }

        // Style class of the menuitem
        public string? StyleClass { get; set; }

        // Tooltip text of the item
        public string? Title { get; set; }

        // Identifier of the element
        public string? Id { get; set; }

        // Value of HTML data-* attribute
        public object? AutomationId { get; set; }

        // Specifies tab order of the item
        public string? TabIndex { get; set; }

        // RouterLink definition for internal navigation
        public string? RouterLink { get; set; }

        // Query parameters for internal navigation via routerLink
        public Dictionary<string, object>? QueryParams { get; set; }

        // Sets the hash fragment for the URL
        public string? Fragment { get; set; }

        // How to handle query parameters in the router link for the next navigation
        public QueryParamsHandling? QueryParamsHandling { get; set; }

        // When true, preserves the URL fragment for the next navigation
        public bool? PreserveFragment { get; set; }

        // When true, navigates without pushing a new state into history
        public bool? SkipLocationChange { get; set; }

        // When true, navigates while replacing the current state in history
        public bool? ReplaceUrl { get; set; }

        // Inline style of the item's icon
        public Dictionary<string, object>? IconStyle { get; set; }

        // Class of the item's icon
        public string? IconClass { get; set; }

        // Developer-defined state that can be passed to any navigation
        public Dictionary<string, object>? State { get; set; }

        // Options of the item's tooltip
        public TooltipOption? TooltipOption { get; set; }

        // Optional
        public Dictionary<string, object>? AdditionalProperties { get; set; }

        public MenuItem()
        {
            Items = new List<MenuItem>();
            Style = new Dictionary<string, object>();
            QueryParams = new Dictionary<string, object>();
            IconStyle = new Dictionary<string, object>();
            State = new Dictionary<string, object>();
            AdditionalProperties = new Dictionary<string, object>();
        }
    }

    public class MenuItemCommandEvent
    {
        public MenuItem? Item { get; set; }
        public EventArgs? OriginalEvent { get; set; }
        public int? Index { get; set; }
    }

    public enum QueryParamsHandling
    {
        Merge,
        Preserve
    }
}
