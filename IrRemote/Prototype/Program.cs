using System;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Prototype
{

    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void DoMouseClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        static void Main(string[] args)
        {
            var names = SerialPort.GetPortNames();
            var port = new SerialPort(names[0]);
            port.BaudRate = 9600;
            port.Encoding = Encoding.ASCII;
            port.Open();
            var timer = new System.Threading.Timer((_) =>
            {
                string str = "";

                while (port.BytesToRead > 0)
                {
                    str += port.ReadExisting();
                }
                if (!string.IsNullOrEmpty(str))
                {
                    var pos = Cursor.Position;
                    Cursor.Position = new System.Drawing.Point(pos.X + 5, pos.Y);
                    
                    Console.WriteLine(str);
                }
            }, port, 500, 50);
            Console.ReadKey();
            timer.Dispose();
            port.Close();
        }
    }
}

