using System;
using System.IO.Ports;
using System.Threading;

namespace InfraMouse
{
    class PortMonitor
    {
        private readonly SerialPort serialPort;
        private Timer timer;
        private IrCodeDispatcher dispatcher = new IrCodeDispatcher();
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
                    dispatcher.Dispatch(str);
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
