using System;
using System.Windows.Forms;

namespace ProftaakGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ddbSerialPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        public String SerialPort
        {
            get { return ddbSerialPorts.Text; }
            set { ddbSerialPorts.Text = value; }
        }
    }
}