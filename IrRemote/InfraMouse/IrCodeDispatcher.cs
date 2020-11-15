using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InfraMouse
{
    public class IrCodeDispatcher
    {
        private static string previousCode;
        private Dictionary<ActionType, Action> map = new Dictionary<ActionType, Action>
        {
            {ActionType.MouseDown, Mouse.Down },
            {ActionType.MouseUp, Mouse.Up },
            {ActionType.MouseRight, Mouse.Right },
            {ActionType.MouseLeft, Mouse.Left },
            {ActionType.MouseLeftClick, Mouse.LeftClick },
            {ActionType.MouseRightClick, Mouse.RightClick }
        };
        public void Dispatch(string code)
        {
            if (code.Length < 6) { code = previousCode; }
            else { previousCode = null; }
            var actionDef = Configuration.Current.Where(x => x.Value.Contains(code)).Select(x => new { action = x.Key }).FirstOrDefault();
            if (actionDef != null)
            {
                previousCode = code;
                map[actionDef.action]();
            }
        }
    }
}
