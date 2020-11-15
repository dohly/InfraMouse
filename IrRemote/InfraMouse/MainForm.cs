using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace InfraMouse
{
    public partial class MainForm : Form
    {
        private PortMonitor monitor;
        private ListBox CurrentListBox => actions.SelectedTab.Controls[0] as ListBox;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCOMPorts();
            InitTabs();
        }

        private void InitTabs()
        {
            actions.TabPages.Clear();
            foreach (var actionDef in Configuration.Current)
            {
                var tab = new TabPage(actionDef.Key.GetName());
                var listBox = new ListBox()
                {
                    Size = portOutput.Size,
                    Top = 5,
                    Tag = actionDef.Key
                };

                listBox.Items.AddRange(actionDef.Value.ToArray());
                tab.Controls.Add(listBox);
                actions.TabPages.Add(tab);
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
            monitor.Received += Log;
            monitor.Watch();
        }

        private void Log(object sender, string code) => portOutput.BeginInvoke((Action)(() => portOutput.Items.Add(code)));

        private void apply_Click(object sender, EventArgs e) => CurrentListBox.Items.Add(portOutput.SelectedItem);

        private void saveButton_Click(object sender, EventArgs e)
        {
            var type = (ActionType)CurrentListBox.Tag;
            Configuration.Current[type] = CurrentListBox.Items.OfType<string>().ToList();
            Configuration.Current.Save();
        }

        private void deleteButton_Click(object sender, EventArgs e) => CurrentListBox.Items.Remove(CurrentListBox.SelectedItem);

        private void changeSubscription_Click(object sender, EventArgs e)
        {
            portOutput.Enabled = !portOutput.Enabled;
            if (portOutput.Enabled)
            {
                monitor.Received += Log;
                changeSubscription.Text = "Unsubscribe";
            }
            else
            {
                monitor.Received -= Log;
                changeSubscription.Text = "Subscribe";
            }
        }
    }
}
