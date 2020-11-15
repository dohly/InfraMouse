using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InfraMouse
{
    public static class Mouse
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void LeftClick() => mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        public static void RightClick() => mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);

        public static void Up() => Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 5);
        public static void Down() => Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y + 5);
        public static void Left() => Cursor.Position = new System.Drawing.Point(Cursor.Position.X - 5, Cursor.Position.Y);
        public static void Right() => Cursor.Position = new System.Drawing.Point(Cursor.Position.X + 5, Cursor.Position.Y);
    }
}
