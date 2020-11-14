using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfraMouse
{
    public partial class MainForm : Form
    {
        private PortMonitor monitor;
        private Configuration config;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCOMPorts();
            config = Configuration.Load();
            InitTabs();
        }

        private void InitTabs()
        {
            actions.TabPages.Clear();
            foreach (var actionDef in config)
            {
                var tab = new TabPage(actionDef.Key);
                actions.TabPages.Add()
            }
        }

        private void LoadCOMPorts()
        {
            var names = SerialPort.GetPortNames();
            ComPortsList.Items.Clear();
            ComPortsList.Items.AddRange(names);
            ComPortsList.SelectedItem = names.FirstOrDefault();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            monitor?.Stop();
            monitor = new PortMonitor(ComPortsList.SelectedItem as string);
            monitor.Received += (s, code) => portOutput.BeginInvoke((Action)(() => portOutput.Items.Add(code)));
            monitor.Watch();
        }

        private void portOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
