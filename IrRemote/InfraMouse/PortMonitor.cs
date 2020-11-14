using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfraMouse
{
    class PortMonitor
    {
        private readonly SerialPort serialPort;
        private Timer timer;
        public PortMonitor(string name)
        {
            serialPort = new SerialPort(name);
        }
        public event EventHandler<string> Received;

        public void Watch()
        {
            timer?.Dispose();
            if (!serialPort.IsOpen) serialPort.Open();

            timer = new Timer((_) =>
            {
                var str = "";
                while (serialPort.BytesToRead > 0)
                {
                    str += serialPort.ReadExisting();
                }
                if (!string.IsNullOrEmpty(str))
                {
                    Received?.Invoke(serialPort, str);
                }
            }, this.serialPort, 500, 50);
        }

        public void Stop()
        {
            timer?.Dispose();
            serialPort.Close();
        }
    }
}
