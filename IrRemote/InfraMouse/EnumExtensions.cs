namespace InfraMouse
{
    internal static class EnumExtensions
    {
        public static string GetName(this ActionType actionType) => actionType switch
        {
            ActionType.MouseDown => "Mouse down",
            ActionType.MouseLeft => "Mouse left",
            ActionType.MouseRight => "Mouse right",
            ActionType.MouseUp => "Mouse up",
            ActionType.MouseLeftClick => "Mouse left click",
            ActionType.MouseRightClick => "Mouse right click",
            _ => "Unknown"
        };
    }
}
